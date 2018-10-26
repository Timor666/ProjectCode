--Table 表遍历

myTable = {}
myTable = {1,2,3,4,5,6,7,8}

for index = 1,table.getn(myTable) do	--只有数字键，这样遍历
	print(myTable[index])
end


myTable2 = {}
myTable2[1] = 2
myTable2['name'] = "提莫"
myTable2["age"] = 14
myTable2["isMan"] = false

for	index,value in pairs(myTable2) do	--所有表可以通过这种格式遍历
	print(index,value)
end


--[[
相关表函数

1.table.concat
	把表中所有数据连成一个字符串
2,table.insert
	向指定位置插入一个数据
3,table.move
	移动数据
4,table.pack
	包装成一个表
5,table.remove
	移除指定位置的数据
6,table.sort
	排序
7,table.unpack
	返回一个数组，指定范围的数组
--]]
