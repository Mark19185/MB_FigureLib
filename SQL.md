<b>Запрос:</b><br><br>
select m2m.Id, product.name, Category.name<br>
from Product product <br>
left join M2M m2m on product.Id = m2m.product_id <br>
left join Category category on m2m.category_id = category.id<br>

