
properties {
  $SolutionFile = "atf.toolbox.CandyStore.sln"
  $ProjectFile = "CandyStore.csproj"
}


# Only Cleans
Task CleanTask  {
    $CleanList = @(
        'bin'
        'obj'
        'packages'
    )
    foreach($Item in $CleanList) {
        try{
            Get-ChildItem $Item -Directory -Recurse | Remove-Item -Force -Confirm:$false -Recurse -ErrorAction SilentlyContinue
        } Catch {
            # Ignore any error
        }
    }
    Remove-Item .\*.nupkg -Force -Confirm:$false -ErrorAction SilentlyContinue
}

# Only NuGet restores
Task NuGetRestoreTask {
    Exec {nuget restore $SolutionFile  }
}

# Only MSBuild compiles 
Task CompileTask {
    Framework "4.5.1x86"
    Exec {msbuild $SolutionFile  "/t:Clean;Rebuild" /m }
}
 

Task Default -Depends Clean, Compile

Task Compile -Depends Clean, NuGetRestoreTask, CompileTask  

Task Clean -Depends CleanTask 

 