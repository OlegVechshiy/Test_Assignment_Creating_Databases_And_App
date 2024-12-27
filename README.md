Инструкция администратора

1. Убедитесь, что установлен SQL Server 2022.
2. Импортируйте базу данных производственных заказов из файла .sql или создайте таблицы вручную, согласно структуре.
3. Установите Visual Studio 2022 на сервере или клиентских машинах.
4. Скомпилируйте приложение и разверните его на целевых машинах.
5. Убедитесь, что все необходимые зависимости (например, библиотеки) установлены.
6. Запустите приложение и выполните первичную настройку конфигурации подключения к базе данных.

Инструкция пользователя

1. Запустите приложение и выберите пункт меню.
2. Для работы с Заголовком или Позициями откройте соответствующую форму.
3. Используйте кнопки для добавления, редактирования и удаления записей.
4. Для поиска выберите поле и введите значение.
5. На формах добавления и редактирования записи есть кнопка Возврат с Сохранением для подтверждения изменений.
6. При попытке сохранить данные выполняется проверка на незаполненные поля или некорректный ввод данных.
7. При отсутствии записей в «Заголовок» доступа к «Позициям» не будет.
8. Для выхода подтвердите действие в диалоговом окне.

Инструкция разработчика

Используемый стек технологий: C#, .NET Framework, WinForms, SQL Server 2022.
Архитектура: MVC с использованием форм для взаимодействия с пользователями, DataGridView для отображения данных. Обработка событий кнопок с валидацией на уровнях ввода данных. Применяется взаимодействие с БД через ADO.NET. На формах добавления и редактирования реализована кнопка Возврат с Сохранением и проверки на корректность ввода.

Физическая модель данных

Физические модели БД представлены в файлах .png
Описание баз данных представлено в скриптовых файлах .sql
