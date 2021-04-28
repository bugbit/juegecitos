#include <stdio.h>
#include <graphics.h>
#include <stdlib.h>
#include <time.h>
#include <dos.h>
#include <ctype.h>
#include <conio.h>
#include <string.h>

#define LADO		100
#define CX			320
#define CY			240-80/2
#define PULSA_MAX	1000
#define PPAUSA    500
#define PPAUSA2	100

struct TRIANGULO {
  int color;
  int puntos[3*2];
  } Triangulos[]={
	{ RED,{ CX,CY,CX,CY-LADO,CX-LADO,CY }},
	{ BLUE,{ CX,CY,CX,CY+LADO,CX-LADO,CY }},
	{ GREEN,{ CX,CY,CX,CY-LADO,CX+LADO,CY }},
	{ YELLOW,{ CX,CY,CX,CY+LADO,CX+LADO,CY }}
  };

char Teclas[]="QAWS\x1B";
char Pulsaciones[PULSA_MAX];
int Apunte=0;
unsigned Num_pul,Pausa=PPAUSA,Pausa2=PPAUSA2,Nivel;

void bold_font();

void esperatecla(void){

  outtextxy(0,379,"Pulse una tecla para continuar");
  getch();

  }

void imprimetexto(char *cadena) {
  int x,y,letras,alto=textheight("W"),ancho=textwidth("n");
  char *n=cadena;
  char buffer[2]="a";

  x=getx();
  y=gety();
  letras=1;
  do {
	 if (!*n || *n==32) {
		if (x+letras*ancho>639) {
		  x=0;
		  if (y+alto>340) {
			 esperatecla();
			 clearviewport();
			 y=0;
			 }
				else
			 y +=alto;
		  moveto(x,y);
		  }
		if (!*n) letras--;
		for (;letras+1>1;letras--) {
		  buffer[0]=*cadena++;
		  outtext(buffer);
		  }
		letras=0;
		x=getx();
		y=gety();
		}
	 letras++;
	 } while (*n++);
  esperatecla();

  }

void Instrucciones()  {

  int tecla;

  setcolor(LIGHTBLUE);
  settextstyle(BOLD_FONT,HORIZ_DIR,3);
  settextjustify(CENTER_TEXT,TOP_TEXT);
  outtextxy(CX,0,"Juego del Sim¢n");
  setcolor(WHITE);
  settextstyle(BOLD_FONT,HORIZ_DIR,1);
  setviewport(0,60,639,479,1);
  settextjustify(LEFT_TEXT,TOP_TEXT);
  imprimetexto(
	 "Este juego estimula la memoria y la capacidad de asociaci¢n de colores"
	 " y sonidos. La computadora nos muestra una sentencia al azar"
	 " entre 4 colores (rojo, azul, verde y amarillo) y nosotros tenemos que"
	 " repetirla en el mismo orden. La sentencia empieza con un color y va"
	 " incrementando en un color, y cada vez la serie se repite m s"
	 " r pidamente y increment ndose de esta manera la dificultad. Si nos"
	 " equivocamos, la computadora nos indicar  el color correcto y luego nos"
	 " muestra toda la serie completa para que la volvamos a repetir. Este"
	 " juego posee infinitos niveles. El primer nivel consiste en una serie de"
	 " cinco colores, el segundo diez, el tercero quince, etc.");
  clearviewport();
  //imprimetexto( "Programa hecho por Oscar Hern ndez Ba¤¢ del grupo C1M2.");
  imprimetexto( "Programa hecho por Oscar Hern ndez Ba¤¢.");
  settextstyle(BOLD_FONT,HORIZ_DIR,2);
  settextjustify(CENTER_TEXT,CENTER_TEXT);
  clearviewport();
  outtextxy(CX,CY,"Introduzca nivel inicial (1-9)");
  do
	 tecla=getch();
	 while (!isdigit(tecla));
  Nivel=tecla-'0';

  }

void Triangulo(int num,int brillante) {

  struct TRIANGULO *t=&Triangulos[num];

  setfillstyle((brillante) ? SOLID_FILL : HATCH_FILL,t->color);
  fillpoly(3,&t->puntos);

  }

void Dibuja() {

  int i;

  clearviewport();
  for (i=0;i<4;i++) Triangulo(i,0);
  settextjustify(CENTER_TEXT,BOTTOM_TEXT);
  outtextxy(CX-LADO/2,CY-LADO,"Q");
  outtextxy(CX+LADO/2,CY-LADO,"W");
  settextjustify(CENTER_TEXT,TOP_TEXT);
  outtextxy(CX-LADO/2,CY+LADO,"A");
  outtextxy(CX+LADO/2,CY+LADO,"S");
  settextstyle(BOLD_FONT,HORIZ_DIR,1);
  outtextxy(CX,430-55,"[ESPACIO] Apunte   [ESC] Salir");
  settextstyle(BOLD_FONT,HORIZ_DIR,2);
  settextjustify(CENTER_TEXT,TOP_TEXT);

  }

void Sonido(int num) {

  sound(440+40*num);
  delay(Pausa);
  nosound();

  }

void Parpadeo(int num) {

  Triangulo(num,1);
  Sonido(num);
  Triangulo(num,0);

  }

void Serie() {

  int i;
  char *s;

  for (s=&Pulsaciones,i=0;i<Num_pul;i++) {
	 Parpadeo(*s++);
	 delay(Pausa2);
	 }
  while (kbhit()) getch(); // borra buffer del teclado

  }

void outtextxyf(int x,int y,char *fmt,...) {

  char buffer[90];
  vsprintf(buffer,fmt,...);
  outtextxy(x,y,buffer);

  }

void Pensar() {

  if (Num_pul==5*Nivel) {
	 clearviewport();
	 settextjustify(CENTER_TEXT,TOP_TEXT);
	 outtextxyf(CX,CY-30,"Has completado con ‚xito el nivel %d",Nivel++);
	 outtextxyf(CX,CY+10,"Vamos al nivel %d",Nivel);
	 getch();
	 Dibuja();
	 Num_pul=0;
	 Pausa=PPAUSA;
	 Pausa2=PPAUSA2;
	 }
		else {
	 delay(500);
	 Pulsaciones[Num_pul++]=random(4);
	 if (Pausa>20) Pausa -= 15;
	 if (Pausa2>20) Pausa2 -= 10;
	 Serie();
	 }

  }

int LeeTecla(int num) {

  int tecla;
  char *s;

  do {
	 if (Apunte)
		while (!kbhit()) {
		  Triangulo(num,1);
		  Triangulo(num,0);
		  }
	 tecla=toupper(getch());
	 if (tecla==' ') Apunte ^= 1;
	 s=strchr(Teclas,tecla);
	 } while (!s);

  return s-&Teclas;

  }

void ParpadeoRapido(int num) {

  int n;

  for (n=0;n<3;n++) {
	 Triangulo(num,1);
	 sound(4000);
	 delay(200);
	 nosound();
	 Triangulo(num,0);
	 }
  sleep(2);

  }

int Sucesion() {

  int i,num;
  char *s;

  for (s=&Pulsaciones,i=0;i<Num_pul;i++,s++) {
	 num=LeeTecla(*s);
	 if (num==4) return 2;
	 Parpadeo(num);
	 if (*s!=num) {
		ParpadeoRapido(*s);
		Serie();
		return 1;
		}
	 }

  return 0;

  }

void Jugar() {

  int opc;

  do {
	 Pensar();
	 while ((opc=Sucesion())==1);
	 } while (!opc);

  }

int main() {

  int gdriver=VGA,gmode=VGAHI;
  int errorcode;

  //registerbgidriver(EGAVGA_driver);
  //registerbgifont(bold_font);
  initgraph(&gdriver,&gmode,"");
  errorcode = graphresult();
  if (errorcode != grOk)  {
	 printf("Error de gr ficos  %s\n", grapherrormsg(errorcode));
	 return 1;
	 }
  randomize();
  Instrucciones();
  Dibuja();
  Jugar();
  closegraph();

  return 0;

  }