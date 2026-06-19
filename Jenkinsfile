pipeline {
    agent any

    stages {
        stage('Clonar') {
            steps {
                echo 'Clonando repositorio...'
            }
        }

        stage('Restaurar') {
            steps {
                bat 'dotnet restore MarcasBlancas/MarcasBlancas.csproj'
            }
        }

        stage('Compilar') {
            steps {
                bat 'dotnet build MarcasBlancas/MarcasBlancas.csproj --configuration Release'
            }
        }

        stage('Pruebas') {
            steps {
                bat 'dotnet test MarcasBlancas.Tests/MarcasBlancas.Tests.csproj'
            }
        }

        stage('Publicar') {
            steps {
                bat 'dotnet publish MarcasBlancas/MarcasBlancas.csproj -c Release -o ./publish'
            }
        }
    }
}
