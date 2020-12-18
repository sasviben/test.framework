Feature: Navigation


  Scenario: the player should be able to open the Lotto page (uid:f98d2847-f151-4bbc-91f9-3917f2626d35)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LOTTO"
    Then the "LOTTO" page is displayed

  Scenario: the player should be able to open the Live page (uid:ab03d30c-2963-470b-b3cd-f11a3d0d4972)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LIVE"
    Then the "LIVE" page is displayed

  Scenario: the player should be able to open the Homepage (uid:ae5ff56c-db20-4ba0-9c1a-d19d5585f317)
    Given the player is on the page "LIVE"
    When the player clicks on the page "SUPERBET"
    Then the "SUPERBET" page is displayed

  Scenario: the player should be able to open the Sport page (uid:909346f1-612d-4018-8a59-d8dec5a0cfee)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SPORT"
    Then the "SPORT" page is displayed

  Scenario: the player should be able to open the Games page (uid:619edcce-67f5-4be6-92f1-f8e3251e1747)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "GAMES"
    Then the "GAMES" page is displayed

  Scenario: the player should be able to open the Casino live page (uid:091287c4-b8f4-449a-8d66-736ad3d42f52)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "CASINO"
    Then the "CASINO" page is displayed

  Scenario: the player should be able to open the Virtual games page (uid:35e4e9e8-aa00-4275-8a5a-bbccd7ff48ff)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "VIRTUAL"
    Then the "VIRTUAL" page is displayed

  Scenario: the player should be able to open the News page (uid:dd7ef12c-b948-42b3-ac65-6cee484f1b63)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "NEWS"
    Then the "NEWS" page is displayed

  Scenario: the player should be able to open the Results page (uid:fabdad62-49a5-45fb-be1b-1b6ff1839a9b)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "RESULTS"
    Then the "RESULTS" page is displayed

  Scenario: the player should be able to open the Shops page (uid:dfa5bd0a-bbae-49f2-9bb0-d6a77f88643f)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SHOPS"
    Then the "SHOPS" page is displayed

  Scenario: the player should be able to open the Help pop up (uid:4f72e00e-9ffb-4278-a10a-b66b75ad6121)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "HELP"
    Then the "HELP" page is displayed

  Scenario: the player should be able to open the Player account page (uid:3527496f-fc1a-48ab-87bd-9dde9a2a21c2)
    Given the player is logged in
    When the player clicks on the page "PLAYER ACCOUNT"
    Then the "PLAYER ACCOUNT" page is displayed

  Scenario: the player should be able to open the Player tickets page (uid:9bfe8d20-e909-4968-b157-34f7969fe863)
    Given the player is logged in
    When the player clicks on the page "PLAYER TICKETS"
    Then the "PLAYER TICKETS" page is displayed

  Scenario: the player should be able to open the Player history page (uid:24bb0ba8-586f-46cb-9984-b25d42ee9bfa)
    Given the player is logged in
    When the player clicks on the page "PLAYER HISTORY"
    Then the "PLAYER HISTORY" page is displayed
