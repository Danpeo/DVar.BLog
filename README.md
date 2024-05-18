# DVar B-Log DEMO

Используется .NET 8, ASP.NET Core и Blazor. Используется ORM Entity Framework Core и СУБД PostgreSQL.
В DVar.BLog.Api/appsettings.json находятся различные параметры: строка подключения к бд, настройки для Email, параметры админа

### Форма обратной связи
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_4.png)

### При отправке, админу приходит уведомление на почту
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_1.png)

### Также в telegram боте приходит сообщение
![Телеграм сообщение](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_10.png)

### Админ может дать ответ на обратную связь
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_3.png)

### Пользователю, придет ответ от админа на почту
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_6.png)

### ERD Базы данных
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_7.png)

### Настройки appsettings.json в DVar.BLog.Api
![Форма обратной связи](https://github.com/Danpeo/DVar.BLog/blob/main/img/Screenshot_8.png)

Для того чтобы получать уведомления в боте, нужно указать chat id, token менять не нужно. Чтобы получить chat id, в браузере ввести https://api.telegram.org/bot7116269176:AAFOikAK0LkXZp9vMA0ELEe6oZHGu7pwI9A/getUpdates и отравить сообщение боту https://t.me/DVarBLogBot
