--�� ʵ���������

myTable = {}

local this = myTable	--this ����ǰ����

--��������

myTable.name = "��Ī"
myTable.age = 18
myTable.money = 1800000


function myTable.Add()		-- һ�ֺ�����ʽ����
	print("add����")
 end


 myTable.Add()	--����
--

 --[[

myTable.function = function A ()

end
--]]		--��ô�ڶ���д���������ȥ



function B()
	print("����B")
end

myTable.B = B
myTable.B()
