Feature: Online


  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:26191d71-2c14-41e6-9eaa-d9b4abaeda8d)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:7904074b-2161-47ea-9c5a-d7b0c3b0b2b3)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch and Special) as on the Betslip (uid:2d2f33dc-0fe3-4ad3-845a-6d287c12c739)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch and Special) as on the Betslip (uid:baa3fd63-cbfb-46e3-8503-38d4c75d2b16)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should see the same data on the purchased mix simple ticket (Prematch, Inplay and Special) as on the Betslip (uid:ab7ea004-1e19-4926-9b82-763320f2585d)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should see the same data on the purchased mix system ticket (Prematch, Inplay and Special) as on the Betslip (uid:62b4880a-4ae2-46e1-a060-d53d4e048bb2)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "WIDGET" is the same as data on the "SPORT" Betslip
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the online player should be able to purchase a Prematch simple ticket (uid:702fa351-1eec-4f31-9462-6681ce503ec9)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Prematch system ticket (uid:b209f182-aa48-4216-b94c-ba99938b3039)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Inplay simple ticket (uid:fd9acb02-c293-4bdc-a815-ab39bebfe329)
    Given the player is logged in
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a Inplay system ticket (uid:bfc8dcc2-e047-4f67-9d66-3534edf38404)
    Given the player is logged in
    And the player has added "3" random "INPLAY" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special simple ticket (uid:0d465d5b-0288-4161-afad-54fe9077b487)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player purchases an "ONLINE" "SPORT" "SIMPLE" ticket
    Then the "ONLINE" "SPORT" "SIMPLE" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake

  Scenario: the online player should be able to purchase a mix Prematch, Inplay and Special system ticket (uid:515fbc3b-d92e-4e4e-8139-bf6f39911203)
    Given the player is logged in
    And the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    And the player has added "1" random "INPLAY" events to the Betslip
    When the player selects "1/5,5/5" combinations on the Betslip
    And the player purchases an "ONLINE" "SPORT" "SYSTEM" ticket
    Then the "ONLINE" "SPORT" "SYSTEM" ticket is purchased
    And the player balance amount is subtracted by the "SPORT" ticket stake
