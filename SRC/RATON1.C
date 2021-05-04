// https://www.programmingsimplified.com/c/c-mouse-programs

#include<graphics.h>
#include<conio.h>
#include<dos.h>

int initmouse();
void showmouseptr();
void getmousepos(int *button, int *x, int *y);
void restrictmouseptr(int, int, int, int);	

union REGS i, o;

main()
{
	int status, gd = DETECT, gm, button, x, y;
	char array[50];

	initgraph(&gd,&gm,"");

	status = initmouse();

   if ( status == 0 )
      printf("Mouse support not available.\n");
   else
   {
	  restrictmouseptr(0,0,getmaxx()-1,getmaxy()-1);
      showmouseptr();

      getmousepos(&button,&x,&y);

      while(!kbhit())
      {
         getmousepos(&button,&x,&y);

         if( button == 1 )
         {
            button = -1;
            cleardevice();
            sprintf(array,"Left Button clicked x = %d y = %d",x,y);
            outtext(array);
         }
         else if( button == 2 )
         {
            button = -1;
            cleardevice();
            sprintf(array,"Right Button clicked x = %d y = %d",x,y);
            outtext(array);
         }

      }
   }

   getch();
   return 0;
}

int initmouse()
{
   i.x.ax = 0;
   int86(0X33, &i, &o);
   return ( o.x.ax );
}

void showmouseptr()
{
   i.x.ax = 1;
   int86(0X33, &i, &o);
}
void getmousepos(int *button, int *x, int *y)
{
   i.x.ax = 3;
   int86(0X33, &i, &o);

   *button = o.x.bx;
   *x = o.x.cx;
   *y = o.x.dx;
}
void restrictmouseptr(int x1, int y1, int x2, int y2)
{
   i.x.ax = 7;
   i.x.cx = x1;
   i.x.dx = x2;
   int86(0X33, &i, &o);

   i.x.ax = 8;
   i.x.cx = y1;
   i.x.dx = y2;
   int86(0X33, &i, &o);
}