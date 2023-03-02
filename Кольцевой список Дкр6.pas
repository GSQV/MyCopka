uses crt;
var num,i,x: integer;
var a:array of integer;
var counter: integer;
var leave:=true;
var leaveIsDemonstration:=true;

procedure dobavlenie1;
var i1: integer;
begin
counter:=counter+1;
SetLength(a,counter);
write('Введите значение нового элемента: ');
readln(x);
a[counter-1]:=x;
writeln(a[counter-1]);
for i1:=0 to counter-1 do
  writeln(a[i1]);
readln();
end;

procedure ydalenie2;
var i1: integer;
begin
  SetLength(a,counter-1);
  for i1:=0 to counter-2 do
  writeln(a[i1]);
readln();
end;

procedure pechatVfail3;
var i1:integer;
var input: text;
begin
  Assign(input,'input1.txt');
  rewrite(input);
  for i1:=0 to counter-1 do
    writeln(input,a[i1]);
  close(input);
  writeln('Список успешно сохранён!');
  readln();
end;

procedure demonstration4;
var i1,x:integer;
begin
while (leaveIsDemonstration=true) do
  begin
  Write('Элемент спика под номером ');
  Write(i1);
  Write(' равен: ');
  Writeln(a[i1]);
  i1:=i1+1;
  readln(x);
  if (x=1) then
    leaveIsDemonstration:=false;
  if (i1=counter) then
    i1:=0;
  end;
end;

procedure menu;

var i: integer;
begin
while (leave=true) do
begin
  Writeln('Сделайте выбор того что нужно сделать:');
  Writeln('1.Добавить элемент в конец списка');
  Writeln('2.Удалить последний элемент');
  Writeln('3.Напечатать список в файл');
  Writeln('4.Продемонстрировать список');
  Writeln('5.Выйти из программы');
  readln(num);
  if num>=6 then 
    exit();
  case num of
  1:dobavlenie1();
  2:ydalenie2();
  3:pechatVfail3();
  4:demonstration4();
  5:leave:=false;
  end;
  ClrScr();
end;
end;

begin
  Write('Введите количество элементов списка: ');
  readln(counter);
  Setlength(a, counter+10);
  for i:=0 to counter-1 do
    readln(a[i]);
  menu();
end.