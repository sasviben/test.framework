#!/bin/bash

TEST_ID="12313"
TEST_CONFIG="UI\Features\hiptest-publisher.conf"
$TEST_FILTER="automated"
browser="Chrome"
environment="QA"
country="Romania"

if [[ -z "${TEST_ID}" ]]; then
  echo "Environment variable TEST_ID cannot be empty!"
  exit 1
fi

if [[ -z "${TEST_CONFIG}" ]]; then
  echo "Environment variable TEST_CONFIG cannot be empty!"
  exit 1
fi

if [[ -z "${browser}" ]]; then
  echo "Environment variable browser cannot be empty!"
  exit 1
fi

if [[ -z "${environment}" ]]; then
  echo "Environment variable environment cannot be empty!"
  exit 1
fi

if [[ -z "${country}" ]]; then
  echo "Environment variable country cannot be empty!"
  exit 1
fi

# Fetch tests
if ! hiptest-publisher \
  --config-file "$TEST_CONFIG" \
  --test-run-id "$TEST_ID" \
  ${TEST_ENVIRONMENT:+--execution-environment "$TEST_ENVIRONMENT" } \
  --only features
then
  echo "Unable to fetch tests, exiting!";
  exit 1;
fi

# Run tests
if ! dotnet test \
    -c Debug \
    ${TEST_FILTER:+--filter "$TEST_FILTER" } \
    --logger 'trx;LogFileName=TESTRESULTS.xml'
then
  echo "Unable to run tests, exiting!";
  exit 1;
fi

if [[ -z "${SKIP_PUBLISH}" ]] || [ "$SKIP_PUBLISH" == "true" ]; then
  # Publish the test results
  hiptest-publisher \
    --config-file "$TEST_CONFIG" \
    --push app/TestResults/TESTRESULTS.xml \
    --test-run-id "$TEST_ID" \
    ${TEST_ENVIRONMENT:+--execution-environment "$TEST_ENVIRONMENT" } \
    --push-format mstest
fi

