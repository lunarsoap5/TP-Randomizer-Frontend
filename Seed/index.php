<?php
echo '<a href="../">Back</a>    <br><br>';

$a = array();
$b = array();
$c = array();
$d = array();
$e = array();
$f = array();
$g = array();
$h = array();
$i = array();
$j = array();

foreach(scandir('.') as $file)
{
    $ext = pathinfo($file, PATHINFO_EXTENSION);
    if ($ext != 'zip' && $ext != 'log') {continue;}
    $n = explode('-', $file)[2];

    switch($n)
    {
        case '[0]':
            array_push($a, $file);
        break;
        case '[1]':
            array_push($b, $file);
        break;        
        case '[2]':
            array_push($c, $file);
            break;
        case '[3]':
            array_push($d, $file);
        break;
        case '[4]':
            array_push($e, $file);
        break;
        case '[5]':
            array_push($f, $file);
        break;
        case '[6]':
            array_push($g, $file);
        break;
        case '[7]':
            array_push($h, $file);
        break;
        case '[8]':
            array_push($i, $file);
        break;
        case '[9]':
            array_push($j, $file);
        break;
        default:
            array_push($a, $file);
        break;
    }
}

function printlinks($links)
{
    foreach($links as $link)
    {
        echo "<li> <a href='$link'>$link</a>";
    }
}

?>

<html>
    <body>
        <head>
    <style type="text/css">
        .tg  {border-collapse:collapse;border-spacing:0;width:100%;height:90%;table-layout: fixed;}
        .tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
        overflow:auto;width:19%;height:40%;padding:.5em;}
        .tg tr {height:40%;min-height:40%;max-height:40%;}
    </style>
    </head>
    <table class="tg">
    <tbody>
    <tr>
        <td class="tg-0lax"><?php printlinks($a); ?></td>
        <td class="tg-0lax"><?php printlinks($b); ?></td>
        <td class="tg-0lax"><?php printlinks($c); ?></td>
        <td class="tg-0lax"><?php printlinks($d); ?></td>
        <td class="tg-0lax"><?php printlinks($e); ?></td>
    </tr>
    <tr>
        <td class="tg-0lax"><?php printlinks($f); ?></td>
        <td class="tg-0lax"><?php printlinks($g); ?></td>
        <td class="tg-0lax"><?php printlinks($h); ?></td>
        <td class="tg-0lax"><?php printlinks($i); ?></td>
        <td class="tg-0lax"><?php printlinks($j); ?></td>
    </tr>
    </tbody>
    </table>
</html>