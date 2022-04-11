<html>
<body>
    <head>
        <script>
            var scroller = setInterval(function() {  
                window.scrollTo(0,document.body.scrollHeight);
            }, 10);
        </script>
    </head>

<?php
set_time_limit(300);
/**
 * This script is executing the generator and redirects the user to the
 * generated seed when finished
 */

try
{
    if(!isset($_POST['generateSeedButton']))
    {
        throw new Exception('Please use the seed generator');
    }

    if (!isset($_POST['settingsStringTextBox']))
    {
        throw new Exception('Those are weird settings');
    }

    $slot = intval($_POST['seed-slot']);

    if ($slot < 0 || $slot > 9)
    {
        throw new Exception('Invalid seed-slot (0-9) make sure javascript is enabled');
    }

    $settingsString = escapeshellarg($_POST['settingsStringTextBox']);
    
    $adjectiveArray = explode("\n", file_get_contents("Resources/HashAdjectives.txt"));
    $nameArray = explode("\n", file_get_contents("Resources/HashNames.txt"));
    shuffle($adjectiveArray);
    
    do
    {
        shuffle($adjectiveArray);
        shuffle($nameArray);
        $seedHash = "[$slot]-".implode('-', array($adjectiveArray[0], $nameArray[0]));
        $seedFile = "Seed/TPR-v1.0-$seedHash.zip";
        $logFile = "Seed/TPR-v1.0-$seedHash.log";
    } while(file_exists($seedFile) || file_exists($logFile));

    while (@ ob_end_flush()); // end all output buffers if any

    $cmd = "dotnet Generator/bin/Debug/net5.0/TPRandomizer.dll $settingsString '$seedHash'";
    $proc = popen($cmd, 'r'); // for Windows, use popen("start /B ". $cmd, 'r'); 
    echo "<h3>TPR 1.0 Seed generator (pre-alpha)</h3><h4>$seedHash</h4><hr><pre>$cmd\n----\n\n";
    $log = "$cmd\n----\n\n";
    while (!feof($proc))
    {
        $chunk = fread($proc, 4096);
        $log .= $chunk;
        echo $chunk;
        flush();
        ob_flush();
    }
    echo '</pre>';

    file_put_contents($logFile, $log);

    if (file_exists($seedFile))
    {
        echo "<h2>Your Seed is available <a href='$seedFile' download>here</a></h2>";
    }
    else
    {
        echo "<h2>Something might've gone wrong because the script couldn't find the supposed target file but you can check the <a href='Seed'>Seed folder</a></h2>";
    }
}
catch(Exception $e)
{
    die("Error: ".$e->getMessage()."<br><br><a href='index.php'>back</a>");
}

?>
    </body>
    <script>
        clearInterval(scroller);
    </script>
</html>