# Подзапросы 

Есть несколько видов подзапросов:
- Скалярный подзапрос
- Табличный подзапрос
- Подзапрос в предикате, также называются коррелированными подзапросами

По сути подзапрос - это запрос внутри другого запроса.
Подзапросы могут быть вложенными, то есть внутри подзапроса может быть еще один подзапрос.

### Скалярный подзапрос

Скалярный подзапрос - это подзапрос, 
который возвращает одно значение.

```sql
select name, (select count(*) from users) as users_count
```

```sql
select name 
from users 
where Age > (select avg(Age) from users)
```

### Табличный подзапрос

Табличный подзапрос - это подзапрос,
который возвращает таблицу.

```sql
select name, (select * from users) as users
```

```sql  
select name
from users
where Age > (select * from (select avg(Age) from users) as avg_age)
```

### Подзапрос в предикате

Подзапрос в предикате - это подзапрос,
который используется в where или having.

```sql
select name from users where id in (select id from users where id > 1)
```

