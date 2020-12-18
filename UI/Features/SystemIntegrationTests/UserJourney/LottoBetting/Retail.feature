Feature: Retail


  Scenario: the player should be able to place a Lotto simple ticket (uid:ba8cb308-dd33-4b8c-a5e9-86a73118db5d)
    Given the player has added "1" random "LOTTO" events to the Betslip
    When the player purchases an "AGENCY" "LOTTO" "SIMPLE" ticket
    Then the "AGENCY" "LOTTO" "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip

  Scenario: the player should be able to place a Lotto system ticket (uid:5560d6c0-5b6f-462a-bdb5-4ccffa782b91)
    Given the player has added "1" random "LOTTO" events to the Betslip
    And the player has added "1" random "LOTTO" events to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "AGENCY" "LOTTO" "SYSTEM" ticket
    Then the "AGENCY" "LOTTO" "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
