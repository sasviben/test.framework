Feature: Navigation


  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Lotto page (uid:d895df3f-72b2-4650-aab8-ae364635cfe6)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LOTTO"
    Then the "LOTTO" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Live page (uid:333cf42d-0725-4e29-8a88-7835a6f5993a)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LIVE"
    Then the "LIVE" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Homepage (uid:89b199d9-ed54-4ef2-a8d4-786a1d995d25)
    Given the player is on the page "LIVE"
    When the player clicks on the page "SUPERBET"
    Then the "SUPERBET" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Sport page (uid:4d4679dd-1212-4fa1-a89f-9842a0735324)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SPORT"
    Then the "SPORT" page is displayed

  @RULES_automated @acceptance @regression
  Scenario: the player should be able to open the Games page (uid:953c3ea1-b328-410b-9de3-57f878a3c777)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "GAMES"
    Then the "GAMES" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Casino live page (uid:e74a10af-1d3a-410a-b3e7-b75b24a92c4e)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "CASINO"
    Then the "CASINO" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Virtual games page (uid:d308f37e-8eea-4f95-9ae5-b80f1818261a)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "VIRTUAL"
    Then the "VIRTUAL" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the News page (uid:fd12947e-f5c9-44f5-a29b-8843d07e24b7)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "NEWS"
    Then the "NEWS" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Results page (uid:e7d6451f-8b71-461e-b5c1-38930eb41667)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "RESULTS"
    Then the "RESULTS" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Shops page (uid:cdbbeb10-7b8b-453c-ba55-7a56b9db4e7d)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SHOPS"
    Then the "SHOPS" page is displayed

  @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Help pop up (uid:e324c779-c707-4c39-88c7-1d9af058496a)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "HELP"
    Then the "HELP" page is displayed

  @online @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Player account page (uid:60e00bd5-ba27-4772-ad5b-82406c92599e)
    Given the player is logged in
    When the player clicks on the page "PLAYER ACCOUNT"
    Then the "PLAYER ACCOUNT" page is displayed

  @online @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Player tickets page (uid:b76218ac-af1a-432e-9735-e5ffa15090ec)
    Given the player is logged in
    When the player clicks on the page "PLAYER TICKETS"
    Then the "PLAYER TICKETS" page is displayed

  @online @RULES_automated @regression @acceptance
  Scenario: the player should be able to open the Player history page (uid:89c19dc2-77c9-4e93-9b6b-ea4a4d5fdeb1)
    Given the player is logged in
    When the player clicks on the page "PLAYER HISTORY"
    Then the "PLAYER HISTORY" page is displayed
