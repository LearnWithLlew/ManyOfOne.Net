# To run this script directly, run this in an elevated admin PowerShell prompt:
#     Invoke-WebRequest -UseBasicParsing https://gist.githubusercontent.com/JayBazuzi/296db9c7ecc15dad0f12287293b11125/raw/setup.ps1 | Invoke-Expression

iwr -useb cin.st | iex
choco feature enable --name=allowGlobalConfirmation
cinst vscode win-no-annoy googlechrome
cinst poshgit git github-desktop
cinst notepadplusplus beyondcompare
cinst visualstudio2019professional visualstudio2019-workload-manageddesktop netfx-4.8-devpack
cinst resharper-ultimate-all ncrunch-vs2019
cinst anydesk

# delete annoying Windows notification sounds
Remove-Item -Recurse HKCU:\AppEvents\Schemes
Set-Service Audiosrv -StartupType Automatic

@(
    'joaompinto.vscode-graphviz'
    'coenraads.bracket-pair-colorizer-2'
    'wmaurer.change-case'
    'streetsidesoftware.code-spell-checker'
    'ryu1kn.partial-diff'
    'ms-vscode.powershell'
    'mohsen1.prettify-json'
    'vscode-icons-team.vscode-icons'
) | % { & "C:\Program Files\Microsoft VS Code\bin\code.cmd" --install-extension $_ }

& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/refactoring-pipelines/Pipelines.git C:\Source\Pipelines

& "${env:ProgramFiles(x86)}\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" /verbosity:minimal C:\Source\Pipelines\Pipelines.sln /target:restore,build

$ProgressPreference = 'SilentlyContinue'
$mobtimeVersion = '1.7.4'
iwr https://github.com/GreatWebGuy/MobTime/releases/download/v$mobtimeVersion/MobTime-$mobtimeVersion.msi -O MobTime.msi
./MobTime.msi /qr

& "${env:ProgramFiles(x86)}\Google\Chrome\Application\chrome.exe" https://marketplace.visualstudio.com/items?itemName=HangjitRai.AutoSaveFile
& "${env:ProgramFiles(x86)}\Google\Chrome\Application\chrome.exe" https://app.mindmup.com/map/new

Write-Host -Foreground yellow "Reboot when done"