Feature: Navigation


  Scenario: the player should be able to open the Homepage (uid:7d304824-00d1-42cb-9639-8992683b866b)
    Given the player is on the page "LIVE"
    When the player clicks on the page "SUPERBET"
    Then the "SUPERBET" page is displayed

  Scenario: the player should be able to open the Sport page (uid:03c4f96a-8f91-43fc-bed3-1c75e8ba9cc7)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SPORT"
    Then the "SPORT" page is displayed

  Scenario: the player should be able to open the Live page (uid:145bc3b7-bd72-4f4e-b066-93401eeb9742)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LIVE"
    Then the "LIVE" page is displayed

  Scenario: the player should be able to open the Lotto page (uid:b070b19c-c7b2-4141-aef8-6b21c69b993e)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "LOTTO"
    Then the "LOTTO" page is displayed

  Scenario: the player should be able to open the Games page (uid:234b95eb-df71-49c3-9cbe-da8087d82558)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "GAMES"
    Then the "GAMES" page is displayed

  Scenario: the player should be able to open the Casino live page (uid:9cfc7f64-a2aa-4d71-8f9c-aa4c407f98cf)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "CASINO"
    Then the "CASINO" page is displayed

  Scenario: the player should be able to open the Virtual games page (uid:04f44f26-f7a8-474f-aac4-d8054f7dbcd0)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "VIRTUAL"
    Then the "VIRTUAL" page is displayed

  Scenario: the player should be able to open the News page (uid:688c4bfe-1ddf-4cc5-9eda-6ce2c8244050)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "NEWS"
    Then the "NEWS" page is displayed

  Scenario: the player should be able to open the Results page (uid:47e1c391-d6cc-451e-b745-d7c420ac7635)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "RESULTS"
    Then the "RESULTS" page is displayed

  Scenario: the player should be able to open the Shops page (uid:f07ed5d5-196f-4f92-97c2-cad9965a08fe)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "SHOPS"
    Then the "SHOPS" page is displayed

  Scenario: the player should be able to open the Help pop up (uid:f9e7e2c9-9fe5-4c27-a075-2b46a119aaed)
    Given the player is on the page "SUPERBET"
    When the player clicks on the page "HELP"
    Then the "HELP" page is displayed

  Scenario: the player should be able to open the Player account page (uid:c382a324-a9ba-4a98-abd3-a82d593e9a54)
    Given the player is logged in
    When the player clicks on the page "PLAYER ACCOUNT"
    Then the "PLAYER ACCOUNT" page is displayed

  Scenario: the player should be able to open the Player tickets page (uid:766102bb-6fa0-4255-a755-172a0408d64d)
    Given the player is logged in
    When the player clicks on the page "PLAYER TICKETS"
    Then the "PLAYER TICKETS" page is displayed

  Scenario: the player should be able to open the Player history page (uid:badbc6e6-cb3c-40bd-a968-099491a597a9)
    Given the player is logged in
    When the player clicks on the page "PLAYER HISTORY"
    Then the "PLAYER HISTORY" page is displayed
