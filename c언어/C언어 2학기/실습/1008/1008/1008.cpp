/*//s1�� ���ڸ� s2�� �Ű��ִ� �ڵ�
#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10];
	int addr;
	int i;
	//s2 = s1; �̿� ���� ���� �Ѵ� ����̱� ������ �������� �ʴ´�.

	//for (i = 0; i < 10; i++)
		s2[i] = s1[i];//
	
	strcpy(s2, s1); //string.h�ȿ� ���ԵǴ� �Լ�

	printf("%s    %s\n", s1, s2);
}*/


//�� ���ڰ� ������ �ٸ��� Ȯ���ϴ� �ڵ�
/*#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10] = "Seoul";
	int i, chk=0;

	for (i = 0; i < 10; i++)
	{
		chk = s1[i] - s2[i];
		if (chk != 0) break;
	}

	if (chk) printf("���� �ʴ�\n");
	else     printf("����\n");
}*/

#include<stdio.h>
#include<string.h>
void main()
{
	char s1[10] = "Seoil";
	char s2[10] = "Seull";

	printf("%s   %s   %d\n", s1, s2, strcmp(s1, s2)); //���ǰͿ��� ���ǰ��� ����.
}
