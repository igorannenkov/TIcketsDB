SELECT T.TicketID AS [ID Заявки], 
U.UserName AS Пользователь, 
T.TicketUserComment AS [Текст обращения], 
COALESCE(UN.UserName, N'Не назначен') AS [Назначенный техник], 
TS.TicketStatusName AS [Статус заявки], 
T.TicketStartDateTime AS [Время регистрации], 
T.TicketEndDateTime AS [Время выполнения], 
T.TicketComment AS [Ответ по обращению], 
DT.DeviceTypeName AS [Используемые материалы] 
FROM Tickets AS T
LEFT JOIN Users AS U 
ON T.UserID = U.UserID 
LEFT JOIN  Users AS UN 
ON T.TechnicID = UN.UserID 
LEFT JOIN Devices AS D 
ON T.UsedDeviceID = D.DeviceID 
LEFT JOIN TicketStatuses TS 
ON T.TicketStatusID = TS.TicketStatusID
LEFT JOIN DeviceTypes AS DT
ON D.DeviceType = DT.DeviceTypeID
WHERE UN.UserName = N'Пушкин А.С.';