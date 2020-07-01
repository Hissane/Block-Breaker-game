pipeline{
    agent any 
    environment{
        GitURL='https://github.com/Hissane/Block-Breaker-game.git'
    }
    stages{
        stage('----CHECKOUT-----'){
            steps{ deleteDir()
            git branch: 'master', url:"${GitURL}"
            echo "Build number -$env.BUILD_NUMBER"}
        }
        stage('---Compile & Build---'){
            steps{ bat '''
                        "C:/Program Files/Unity/Hub/Editor/2020.1.0b13/Editor/Unity.exe" -projectPath "./Block Breaker"
                        -quit -nographics -batchmode -logFile "./Logs/Packages-Update.log" -executedMethod UnityBuild.BuildPlatforms
                        '''}
        }
         stage('---Run & Test---'){
            steps{ bat '''
                        "C:/Program Files/Unity/Hub/Editor/2020.1.0b13/Editor/Unity.exe" -batchmode -runEditorTests "./Block Breaker" -testFilter
                        "./Block Breaker/Library/ScriptAssemblies/NewAssembly.dll" -editorTestResultFile "./Test/UnitTestResult.xml"
                        '''}
        }
    }
    post {
        always {echo 'the service is running'}
        success {echo 'the service is running:success'}
        failure {echo 'the service is running:failure '}
    }
}