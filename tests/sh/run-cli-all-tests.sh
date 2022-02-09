#!/bin/bash

CL_GREEN='\033[0;32m'
CL_NC='\033[0m'

WORK_PATH=./
FILE_NAME='test-results.md'

run_script()
{
  chmod 755 $1
  echo -n "Running $1 "
  echo '```tap' >> $FILE_NAME
  echo $1 >> $FILE_NAME
  echo '' >> $FILE_NAME  
  $WORK_PATH$1 >> $FILE_NAME
  echo '```' >> $FILE_NAME
  echo '' >> $FILE_NAME
  echo -e "[${CL_GREEN}OK${CL_NC}]"
}

rm -f $FILE_NAME

echo '# Test Results' >> $FILE_NAME
echo '' >> $FILE_NAME

run_script run-cli-sessionbrowser-unit-test.sh
run_script run-cli-gametelemetry-unit-test.sh
run_script run-cli-seasonpass-unit-test.sh
run_script run-cli-basic-unit-test.sh
run_script run-cli-iam-unit-test.sh
run_script run-cli-group-unit-test.sh
run_script run-cli-social-unit-test.sh
run_script run-cli-eventlog-unit-test.sh
run_script run-cli-platform-unit-test.sh
run_script run-cli-leaderboard-unit-test.sh
run_script run-cli-cloudsave-unit-test.sh
run_script run-cli-matchmaking-unit-test.sh
run_script run-cli-legal-unit-test.sh
run_script run-cli-lobby-unit-test.sh
run_script run-cli-qosm-unit-test.sh
run_script run-cli-dslogmanager-unit-test.sh
run_script run-cli-ugc-unit-test.sh
run_script run-cli-dsmc-unit-test.sh
run_script run-cli-achievement-unit-test.sh
run_script run-cli-gdpr-unit-test.sh
