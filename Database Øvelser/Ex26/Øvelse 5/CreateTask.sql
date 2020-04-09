CREATE TABLE Task(
TaskID		iNT					Identity(1,1),
Type		NvarChar(100)		Null,
Hours		Decimal(3,2)		Not null,
--
CONSTRAINT		TASK_PK			PRIMARY KEY(TaskID) 	
)