--Table �����

myTable = {}
myTable = {1,2,3,4,5,6,7,8}

for index = 1,table.getn(myTable) do	--ֻ�����ּ�����������
	print(myTable[index])
end


myTable2 = {}
myTable2[1] = 2
myTable2['name'] = "��Ī"
myTable2["age"] = 14
myTable2["isMan"] = false

for	index,value in pairs(myTable2) do	--���б����ͨ�����ָ�ʽ����
	print(index,value)
end


--[[
��ر���

1.table.concat
	�ѱ���������������һ���ַ���
2,table.insert
	��ָ��λ�ò���һ������
3,table.move
	�ƶ�����
4,table.pack
	��װ��һ����
5,table.remove
	�Ƴ�ָ��λ�õ�����
6,table.sort
	����
7,table.unpack
	����һ�����飬ָ����Χ������
--]]
