<?php
echo '<a href="../">Back</a>    <br><br>';
foreach(scandir('.') as $f)
{
    $ext = pathinfo($f, PATHINFO_EXTENSION);
    if ($ext != 'zip' && $ext != 'log') continue;
    echo "<a href='$f' download>$f</a><br>";
}
?>