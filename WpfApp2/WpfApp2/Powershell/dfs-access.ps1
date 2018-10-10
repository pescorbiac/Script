param([string]$link)

$toto ="tot-tata3"
Start-sleep -s 15
$a =((Get-Item -Path ".\").FullName).replace( "bin\Debug","Powershell\AccessRW.txt")


$toto >> $a

$link >> C:\Users\pescorbiac\source\repos\Script-Axa\WpfApp2\WpfApp2\Powershell\AccessRW.txt
$toto >> C:\Users\pescorbiac\source\repos\Script-Axa\WpfApp2\WpfApp2\Powershell\AccessR.txt