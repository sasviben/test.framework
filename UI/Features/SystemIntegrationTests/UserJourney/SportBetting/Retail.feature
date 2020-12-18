Feature: Retail


  Scenario: the player should be able to purchase a Prematch simple ticket (uid:36a0bdcf-f201-4095-b773-9a2c11a46965)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should be able to purchase a Prematch system ticket (uid:8dd50def-fea2-40e2-8393-97ea514f8c27)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "AGENCY" "" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:d6879fda-db2d-4d70-b37f-6976f60b200a)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:444baea8-1779-483f-a9cb-c8bb74059d42)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" "SPORT" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the player should be able to purchase a mix Prematch and Special simple ticket (uid:fb30b5d2-d4f6-4dea-be4e-e0974696edea)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should be able to purchase a mix Prematch and Special system ticket (uid:16da4422-286f-44db-93bf-a8a8fc22fd96)
    Given the player has added "3" random "PREMATCH" events to the Betslip
    And the player has added "1" random "SPECIAL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" "SPORT" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SYSTEM" ticket is purchased
