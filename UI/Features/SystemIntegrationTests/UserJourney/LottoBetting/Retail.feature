Feature: Retail


  Scenario: the player should be able to place a Lotto simple ticket (uid:715c1bd2-6634-4f15-bbd4-5da50213aed0)
    Given the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    When the player purchases an "AGENCY" "LOTTO" "SIMPLE" ticket
    Then the "AGENCY" "LOTTO" "SIMPLE" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip

  Scenario: the player should be able to place a Lotto system ticket (uid:4c74eb38-950b-4f33-8246-d271f32ec706)
    Given the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    And the player has added "1" random "LOTTO" "FOOTBALL" events to the Betslip
    When the player selects "RANDOM" combinations on the Betslip
    And the player purchases an "AGENCY" "LOTTO" "SYSTEM" ticket
    Then the "AGENCY" "LOTTO" "SYSTEM" ticket is purchased
    And the data on the "DETAILS" is the same as data on the "LOTTO" Betslip
