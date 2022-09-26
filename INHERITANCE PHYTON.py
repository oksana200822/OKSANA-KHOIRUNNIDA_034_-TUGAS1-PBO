class Hewan:

     def __init__(self, nama, warna):
         self.nama = nama     
         self.warna = warna

class Kucing(Hewan):
     def makan(self):
         print("Kucing sedang makan")

class anjing(Hewan):
     def melahirkan(self):
         print("anjing sedang melahirkan")

binatang = Kucing("catty", "putih")
 
print(binatang.warna)
binatang.makan()