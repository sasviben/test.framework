Feature: Retail


  Scenario: the player should be able to purchase a Prematch simple ticket (uid:fdea6fc5-a9fb-441f-a83b-524e2a950597)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should be able to purchase a Prematch system ticket (uid:beff3e1f-a40a-4e2f-8a79-2c2216a0fe81)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    When the player selects "1/3,3/3" combinations on the Betslip
    And the player purchases an "AGENCY" "" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should see the same data on the purchased mix simple ticket (Prematch and Inplay) as on the Betslip (uid:bfe34263-9dea-4944-846d-6b008cebbda3)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the player should see the same data on the purchased mix system ticket (Prematch and Inplay) as on the Betslip (uid:c3b22c9e-9d2d-44f3-96a4-2765412593a3)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" "SPORT" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "SPORT" Betslip

  Scenario: the player should be able to purchase a mix Prematch and Special simple ticket (uid:9c11c4e4-99cb-431b-a4c6-35a061e525d9)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" "SPORT" "SIMPLE" ticket
    Then the "AGENCY" "SPORT" "SIMPLE" ticket is purchased

  Scenario: the player should be able to purchase a mix Prematch and Special system ticket (uid:a2975afe-d7f5-4614-a0ed-96bc8546a9f6)
    Given the player has added "3" random "PREMATCH" "FOOTBALL" events to the Betslip
    And the player has added "1" random "SPECIAL" "FOOTBALL" events to the Betslip
    When the player selects "1/4,4/4" combinations on the Betslip
    And the player purchases an "AGENCY" "SPORT" "SYSTEM" ticket
    Then the "AGENCY" "SPORT" "SYSTEM" ticket is purchased
