#language: ru
@Test
Функция: Login Test	
		
	Предыстория: Open MailRU
		Дано I open "http://www.mail.ru"
		
	Сценарий: login
		Дано I don't see "User eMail Text"
		Если I type "shaforost.olga" into "Login Part Field"
		И I select "@mail.ru" into "Domain"
		И I type "test_123" into "Password Field"
		И I click "Login Button"
		То I see "User eMail Text"
		И I exit
		И I don't see "User eMail Text"