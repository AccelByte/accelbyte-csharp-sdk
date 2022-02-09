library(
  identifier: 'jenkins-shared-library@master',
  retriever: modernSCM(
    [
      $class: 'GitSCMSource',
      remote: 'https://github.com/dhanarab/jenkins-pipeline-library.git'
    ]
  )
)

bitbucketCredentialsHttps = "Bitbucket_Build_AccelByte"
bitbucketCredentialsSsh = "build_account_bitbucket_key"

bitbucketPayload = null
bitbucketCommitHref = null

pipeline {
  agent {
    label "justice-codegen-sdk"
  }
  stages {
    stage('Prepare') {
      steps {
        script {
          if (env.BITBUCKET_PAYLOAD) {
            bitbucketPayload = readJSON text: env.BITBUCKET_PAYLOAD
            if (bitbucketPayload.pullrequest) {
              bitbucketCommitHref = bitbucketPayload.pullrequest.source.commit.links.self.href
            }
          }
          if (bitbucketCommitHref) {
            bitbucket.setBuildStatus(bitbucketCredentialsHttps, bitbucketCommitHref, "INPROGRESS", env.JOB_NAME, "${env.JOB_NAME}-${env.BUILD_NUMBER}", "Jenkins", "${env.BUILD_URL}console")
          }
        }
      }
    }
    stage('Lint') {
      stages {
        stage('Lint Commits') {
          when {
            expression {
              return env.BITBUCKET_PULL_REQUEST_LATEST_COMMIT_FROM_TARGET_BRANCH
            }
          }
          agent {
            docker {
              image 'randondigital/commitlint:3.0'
              reuseNode true
            }
          }
          steps {
            sh "npm install @commitlint/config-conventional@13.2.0"
            sh "commitlint --color false --verbose --from ${env.BITBUCKET_PULL_REQUEST_LATEST_COMMIT_FROM_TARGET_BRANCH}"
          }
        }
        stage('Lint spec') {
          steps {
            sh "[ -f spec/TIMESTAMP ] || exit 1"  // Make sure TIMESTAMP file is present in spec directory
          }
        }
      }
    }
    stage('Build') {
      steps {
        sh "make build"
      }
    }
    stage('Test') {
     stages {
       stage('Unit Tests') {
         steps {
            sshagent(credentials: [bitbucketCredentialsSsh]) {
              sh "rm -rf .justice-codegen-sdk-mock-server"
              sh "git clone --depth 1 git@bitbucket.org:accelbyte/justice-codegen-sdk-mock-server.git .justice-codegen-sdk-mock-server"
            }
           sh "make test SDK_MOCK_SERVER_PATH=.justice-codegen-sdk-mock-server"
         }
       }
     }
    }
  }
  post {
    success {
      script {
        if (bitbucketCommitHref) {
          bitbucket.setBuildStatus(bitbucketCredentialsHttps, bitbucketCommitHref, "SUCCESSFUL", env.JOB_NAME, "${env.JOB_NAME}-${env.BUILD_NUMBER}", "Jenkins", "${env.BUILD_URL}console")
        }
      }
    }
    failure {
      script {
        if (bitbucketCommitHref) {
          bitbucket.setBuildStatus(bitbucketCredentialsHttps, bitbucketCommitHref, "FAILED", env.JOB_NAME, "${env.JOB_NAME}-${env.BUILD_NUMBER}", "Jenkins", "${env.BUILD_URL}console")
        }
      }
    }
  }
}
