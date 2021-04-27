!/bin/bash
#----TEST RUNS----
# regression test run ID: 513396
# smoke test run ID: 514339
#----EXECUTION ENVIRONMENT----
# Silent
# Stage
# QA


TEST_RUN_ID="513396"
TEST_CONFIG="UI\Features\hiptest-publisher.conf"
TEST_ENVIRONMENT="Silent"
TEST_FILTER="TestCategory=regression"
environment="Silent"
browser="Chrome"

if [[ ! -d "$environment" ]]; then 
    export environment
fi

#internet preglednik u kojem će se izvršiti testovi
 if [[ ! -d "$browser" ]]; then 
     export browser
 fi

# Fetch tests
if ! hiptest-publisher \
	--config-file "$TEST_CONFIG" \
	--test-run-id "$TEST_RUN_ID" \
	--execution-environment "$TEST_ENVIRONMENT" \
	--only features
then
	echo "Unable to fetch tests, exiting!"
fi
# Run tests
dotnet test \
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
