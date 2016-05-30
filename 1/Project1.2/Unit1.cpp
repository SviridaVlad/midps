//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

int width;
int height;
int x;
int y;


//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
Button2->Enabled = false;
}

void DrawLine()
{
        y = (height / 2.0) + (rand() % 41 - 20);
        Form1->PaintBox1->Canvas->LineTo(++x, y);
        Form1->Panel2->Height = y;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
   DrawLine();

}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        PaintBox1->Repaint();
        PaintBox1->Canvas->Pen->Color = clRed;
        width = Form1->PaintBox1->Width;
        height = Form1->PaintBox1->Height;
        x = 0;
        PaintBox1->Canvas->MoveTo(0, height / 2.0);
        Button2->Enabled = true;
        Button1->Enabled = false;
        Timer1->Enabled = true;
        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Timer1->Enabled = false;
        Button1->Enabled = true;
        Button2->Enabled = false;
        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::PaintBox1Paint(TObject *Sender)
{
        PaintBox1->Canvas->Pen->Color = clBlack;
        PaintBox1->Canvas->Brush->Color = clBlack;
        PaintBox1->Canvas->Brush->Style = bsCross;
        PaintBox1->Canvas->Rectangle(0, 0, PaintBox1->Width, PaintBox1->Height);

}
//---------------------------------------------------------------------------

