--表 实现面向对象

myTable = {}

local this = myTable	--this 代表当前对象

--定义属性

myTable.name = "提莫"
myTable.age = 18
myTable.money = 1800000


function myTable.Add()		-- 一种函数格式声明
	print("add函数")
 end


 myTable.Add()	--调用
--

 --[[

myTable.function = function A ()

end
--]]		--怎么第二种写法编译过不去



function B()
	print("函数B")
end

myTable.B = B
myTable.B()
