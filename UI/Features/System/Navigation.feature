Feature: Navigation


  Scenario: The user should be able to open the Homepage (uid:aad1e2ed-6ccf-4848-b770-a47229999bf8)
    Given the user is on the page "Live"
    When the user clicks on the page "Superbet"
    Then the "Homepage" page is displayed

  Scenario: The user should be able to open the Sport page (uid:fa493c6e-86e5-41de-9494-75dd28f45bd0)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Sport"
    Then the "Sport" page is displayed

  Scenario: The user should be able to open the Live page (uid:0a59ccac-20ab-4b99-a708-65495fe9d066)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Live"
    Then the "Live" page is displayed

  Scenario: The user should be able to open the Lotto page (uid:b401737e-7ae0-4c29-9249-ad818fae44a6)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Lotto"
    Then the "Lotto" page is displayed

  Scenario: The user should be able to open the Games page (uid:0d967f3c-1967-4c3a-9d87-f641c5cd81cf)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Games"
    Then the "Games" page is displayed

  Scenario: The user should be able to open the Casino live page (uid:21f05b42-4171-42a5-8b70-43bde9bbf3d4)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Casino"
    Then the "Casino" page is displayed

  Scenario: The user should be able to open the Virtual games page (uid:7d441ce7-5845-4fd1-90f0-4e6a87d730ed)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Virtual"
    Then the "Virtual" page is displayed

  Scenario: The user should be able to open the News page (uid:eb6cecc2-6a44-41f5-b64e-497f2a0a9797)
    Given the user is on the page "Superbet"
    When the user clicks on the page "News"
    Then the "News" page is displayed

  Scenario: The user should be able to open the Results page (uid:eb5caaec-9743-4f06-9e20-73a0700b05c8)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Results"
    Then the "Results" page is displayed

  Scenario: The user should be able to open the Shops page (uid:83f0b392-7650-4745-9454-d63ee2cb189f)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Shops"
    Then the "Shops" page is displayed

  Scenario: The user should be able to open the Help pop up (uid:8ccae7e6-84e8-4e68-980f-89075655f8cd)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Help"
    Then the "Help" page is displayed

  Scenario: The user should be able to open the Player account page (uid:44a30f06-fb6e-45b9-b921-4a88abc198f4)
    Given the user is on the page "Superbet"
    And the user is logged in
    When the user clicks on the page "Player account"
    Then the "Player account" page is displayed

  Scenario: The user should be able to open the Player tickets page (uid:56615819-64cc-4853-a8cc-97ffe70cbb88)
    Given the user is on the page "Superbet"
    And the user is logged in
    When the user clicks on the page "Player tickets"
    Then the "Player tickets" page is displayed

  Scenario: The user should be able to open the Player history page (uid:62d2ad5a-8f49-41df-8ce1-e1249352bbb6)
    Given the user is on the page "Superbet"
    And the user is logged in
    When the user clicks on the page "Player history"
    Then the "Player history" page is displayed
 
  Scenario: The user should be able to open the Promotions page (uid:0c492a35-a0b3-4485-a273-edc12407d611)
    Given the user is on the page "Superbet"
    When the user clicks on the page "Promotions"
    Then the "Promotions" page is displayed

