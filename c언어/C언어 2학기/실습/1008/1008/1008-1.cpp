#include<stdio.h>
/*void main()
{
	int n[5] = { 10, 20, 30, 40, 50 };
	int *p;
	p = n;

	printf("%d\n",*p);
	p = p + 1;
	printf("%d\n", *p);
}*/

void main()
{
	int n; //������ �� �� �ִ� ���� Ȯ��
	int *p;// �ּҰ� �� �� �ִ� ���� p Ȯ��
	       // �ּҸ� ã�ư��� ������ data�� ����
	p = &n;//������ ������ ������ ����
           //������ �ּҸ� ������ ������ data�� ����
	n = 10;
	printf("%d  %d\n", n, *p);
	*p = n + 20;
	printf("%d  %d\n", n, *p);

}      