Feature: Lotto Online Betting


  Scenario: The online user should be able to place a Lotto ticket (uid:d132cfff-926d-495a-a9ca-3269eca8a0be)
    Given the online user is on the page "LOTTO"
    And the user has added lotto event to the bet slip
    When the user purchases a "LOTTO" "SIMPLE" ticket
    Then the data on the "WIDGET" is the same as data on the "LOTTO" bet slip
    And the data on the "DETAILS" is the same as data on the "LOTTO" bet slip
    And the user balance amount is subtracted by the "LOTTO" ticket stake
