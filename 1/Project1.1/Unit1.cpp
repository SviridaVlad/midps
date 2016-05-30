//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
Timer1->Enabled=False;
}
int i=0,x1=0,x2=0,x3=0,x4=0,x5=0;
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
i++;
        if(i==10){ x1++; i=0;   }
        if(x1==6) { x2++; i=0; x1=0; }
        if(x2==10) { x3++; x2=0; }
        if(x3==6) { x4++; x3=0; x2=0; }
        if(x4==10) { x5++; x4=0; }
        if(x5==2 && x4==4) { x5=0; x4=0; i=0; }

        Edit1->Text=IntToStr(x5)+IntToStr(x4)+":"+IntToStr(x3)+IntToStr(x2)+":"+IntToStr(x1)+IntToStr(i);
        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
Timer1->Enabled=False;
Button2->Enabled=False;
Button3->Enabled=True;
        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button2Click(TObject *Sender)
{
Timer1->Enabled=True;
Button2->Enabled=True;
Button3->Enabled=False;
        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
i=0;x1=0;x2=0;x3=0;x4=0;x5=0;
Edit1->Text="00:00:00";
        
}
//---------------------------------------------------------------------------

