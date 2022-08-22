Feature: Commenting
	Customer can comment on a story

@mytag
Scenario:Verify customer not signed is redirected to sign in page to enable commenting
	Given i navigate to BBC homepage
	And i am on the sports page
	And i am on post page
	And i click on comment icon
	When i click on signin button 
	Then i am redirected to sign in page 

	


	
	