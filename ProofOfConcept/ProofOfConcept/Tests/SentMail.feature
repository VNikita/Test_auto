#language: ru
@Test
Функция: SendMail	
		
	Предыстория: Open MailRU
		Дано Пользователь открывает "http://www.mail.ru"
		
	Сценарий: login
		Дано Пользователь не видит сообщение "User eMail Text"
		Если Пользователь заполняет "nikita.varchenko" в поле "Login Part Field"
		И Пользователь выбирает "@inbox.ru" в поле "Domain"
		И  Пользователь заполняет "NKapIM2015g" в поле "Password Field"
		И Пользователь нажимает "Login Button"
		То Пользователь видит сообщение "User eMail Text"

	Сценарий: Send
		Дано Пользователь видит сообщение "User eMail Text"
		Если Пользователь нажимает "Написать письмо (N)"
		И Пользователь заполняет "vnvkap@gmail.co" в поле "To"
		И Пользователь заполняет "Test" в поле "Subject"
		И Пользователь заполняет "Test" в поле "Momo"
		И Пользователь нажимает "Sent Button"
		То Пользователь видит сообщение "User sent Text"
		И Пользователь нажимает "Inbox Button"

	Сценарий: check and Exit
		Дано Пользователь видит сообщение "Text Subject mail"
		Если Пользователь нажимает "Exit Button"
		То Пользователь не видит сообщение "User eMail Text"