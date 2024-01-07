# Views

`Views` - это макрос,
который хранит ваш запрос в формате 
самого запроса, а не данных. 

Давайте разберем как это работает на 
самом деле.

## Пример

```sql
CREATE VIEW my_view AS
select Name, Surname from users;
```