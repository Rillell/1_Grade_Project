#include<stdio.h>
void main()
//{
//	char str1[10] = "Seoil"; // ���ڿ� �迭 : ������� 4����Ʈ�� ������ �� ����.
//	char *str2 = "Seoil"; // ���ڿ� ������ : ���۵Ǵ� �ּҸ� ������ ����. �޸��� ���� ����.
//
//	printf("%s    %s", str1, str2);
//}

{
	int n = 10;
	int *p1;
	int **p2;

	p1 = &n;
	p2 = &p1;

	printf("%d    %d    %d\n", n, *p1, **p2);

	printf("%p  %p  %p  %p  %p", &n, p1, &p1, p2, &p2);

}