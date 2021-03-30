# web.test.UI
**Ime paketa:** web.test.UI
Test aplikacija je razvijena koristeći BDD metodologiju. Tehnologije koje se koriste su Specflow i Selenium.
Aplikacija sadrži UI testove koji pokrivaju sistemsku i sistem integracijsku razinu testiranja.

### Aplikacija je više-platformska
Napisana je u .NET 5 razvojnom okviru i kao takva se može isporučiti na bilo koju platformu (Widnows, Linux...).
## Upute za instalaciju i pokretanje aplikacije
###### Integracija sa Cucumber Studiom
Naredba koju je potrebno izvršiti kako bi se povukli testovi iz željenog test paketa:
```
$env:TEST_CONFIG="UI\Features\hiptest-publisher.conf"
$env:TEST_RUN_ID="513396"
$env:TEST_ENVIRONMENT="QA"
hiptest-publisher --config-file "$TEST_CONFIG" --test-run-id "$TEST_RUN_ID" --execution-environment "$TEST_ENVIRONMENT" --only features
```
Naredba koju je potrebno izvršiti kako bi se pokrenuli željeni testovi:
```
$env:browser="chrome"
$env:environment="QA"
$env:TEST_FILTER="TestCategory=RULES_automated"
dotnet test -c Debug --filter "$TEST_FILTER" --logger "trx;LogFileName=TESTRESULTS.xml"
```
Naredba koju je potrebno izvršiti kako bi se rezultati poslali u CucumberStudio:
```
$env:browser="chrome"
$env:environment="QA"
$env:TEST_FILTER="TestCategory=RULES_automated"
hiptest-publisher --config-file "$TEST_CONFIG" --push UI/TestResults/TESTRESULTS.xml --test-run-id "$TEST_RUN_ID" --execution-environment "$TEST_ENVIRONMENT" --push-format mstest
```
