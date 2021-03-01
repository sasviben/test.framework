# web.test.UI
**Ime paketa:** web.test.UI
Test aplikacija je razvijena koristeći BDD metodologiju. Tehnologije koje se koriste su Specflow i Selenium.
Aplikacija sadrži UI testove koji pokrivaju sistemsku i sistem integracijsku razinu testiranja.

### Aplikacija je više-platformska
Napisana je u .NET 5 razvojnom okviru i kao takva se može isporučiti na bilo koju platformu (Widnows, Linux...).
### Aplikacija je zapakirana u Docker kontejner
Aplikacija se builda u docker kontejner te se kao takva lako može isporučiti na razne platforme. 
## Upute za instalaciju i pokretanje aplikacije
###### Integracija sa Cucumber Studiom
Naredba koju je potrebno izvršiti kako bi se povukli testovi iz željenog test paketa:
```
hiptest-publisher --config-file .\hiptest-publisher.conf --test-run-id {test run id} --only features
```
Naredba koju je potrebno izvršiti kako bi se pokrenuli željeni testovi:
```
$env:seleniumHubHost="localhost"
>> $env:seleniumHubPort="4446"
>> $env:browser="chrome"
>> $env:environment="Production"
>> dotnet test --configuration Release --filter 'TestCategory=regression' --logger "trx;LogFileName=TESTRESULTS.xml"
```
