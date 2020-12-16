Feature: Sport Online Betting


  Scenario: The online user should be able to purchase a mix simple ticket (uid:e5baace2-9be4-4b9a-b816-106e78bdcd22)
    Given the online user has added "3" "SPORT" events to the bet slip
    And the online user has added "1" "LIVE" events to the bet slip
    When the user purchases a "SPORT" "SIMPLE" ticket
    Then the data on the "WIDGET" is the same as data on the "SPORT" bet slip
    And the data on the "DETAILS" is the same as data on the "SPORT" bet slip
    And the user balance amount is subtracted by the "SPORT" ticket stake

  Scenario: The online user should be able to purchase a Sport system ticket (uid:c1232f6f-0bdf-49aa-a187-8f30fad13da3)
    Given the online user has added "2" "SPORT" events to the bet slip
    When the user purchases a "SPORT" "SYSTEM" ticket
    Then the ticket is purchased
