<b>Запрос:</b><br><br>
select product.name, Category.name<br>
from Product product <br>
left join M2M m2m on product.Id = m2m.product_id <br>
left join Category category on m2m.category_id = category.id<br>

<b>Вывод:</b><br>
<img src="sql.png"></img>
