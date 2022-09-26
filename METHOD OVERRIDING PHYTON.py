class Hewan:
     def __init__(self, nama, warna):     
          self.nama = nama     
          self.warna = warna 

     def makan(self):     
          print("Sedang makan")

class Kucing(Hewan):
     def makan(self):
          print("Sedang makan-makan")

binatang = Kucing("catty", "putih")

print(binatang.warna)
binatang.makan()
    