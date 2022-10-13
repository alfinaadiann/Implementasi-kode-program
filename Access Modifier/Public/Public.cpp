#include <iostream>
using namespace std;
 
class mahasiswa
{
public: 
//accessspecifier
    int id;
};
 
int main ()
{
    mahasiswa alfina;
    alfina.id = 14;
    cout<<"Implementasi access modifier public\n";
    cout<<alfina.id<<endl;
}
