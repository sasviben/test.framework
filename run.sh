#!/bin/bash
#----TEST RUNS----
# regression test run ID: 513396
# acceptance test run ID: 514338
# smoke test run ID: 514339
#----EXECUTION ENVIRONMENT----
# Silent
# Stage
# QA

TEST_RUN_ID="513396"
TEST_CONFIG="UI\Features\hiptest-publisher.conf"
TEST_ENVIRONMENT="QA"
#TEST_FILTER="regression"
TEST_FILTER="TestCategory=RULES_automated"

# Fetch tests
if ! hiptest-publisher \
	--config-file "$TEST_CONFIG" \
	--test-run-id "$TEST_RUN_ID" \
	--execution-environment "$TEST_ENVIRONMENT" } \
	--only features
then
	echo "Unable to fetch tests, exiting!"
fi
# Run tests
dotnet test \
	-c Debug \
    --filter "$TEST_FILTER" \
    --logger 'trx;LogFileName=TESTRESULTS.xml'

# Publish the test results
if ! hiptest-publisher \
    --config-file "$TEST_CONFIG" \
    --push UI/TestResults/TESTRESULTS.xml \
    --test-run-id "$TEST_RUN_ID" \
    --execution-environment "$TEST_ENVIRONMENT" \
    --push-format mstest
then
	echo "Unable to push test results, exiting!"
fi
