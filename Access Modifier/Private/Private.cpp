#include <iostream>
using namespace std;
 
class mahasiswa{
private:
    int id;
 
public:
    int getId(){
        return id;
    }
 
    void setId(int i){
        id = i;
    }
};
 
int main (){
    mahasiswa alfina;
    alfina.setId(2);
    cout<<"Implementasi Access Modified Private\n";
    cout<<alfina.getId()<<endl;
}
