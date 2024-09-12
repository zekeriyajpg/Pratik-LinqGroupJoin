# LINQ Group Join Example in C#

Bu proje, bir okul veri tabanındaki öğrenciler ve sınıflar arasında **LINQ Group Join** işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir yapıyı gösterir.

## Proje Açıklaması

Bu C# uygulaması, iki temel sınıf olan `Student` ve `Class` sınıfları ile çalışmaktadır. Öğrencilerin hangi sınıfa ait olduğunu göstermek amacıyla, LINQ Group Join sorgusu kullanılmıştır. Bu sayede, her sınıf altında o sınıfa ait öğrenciler listelenmiştir.

## Kod Yapısı

### `Student` Sınıfı
`Student` sınıfı, öğrenci bilgilerini içerir. Aşağıdaki özelliklere sahiptir:

- `StudentId`: Öğrencinin benzersiz kimliği (int).
- `StudentName`: Öğrencinin adı (string).
- `ClassId`: Öğrencinin bağlı olduğu sınıfın kimliği (int).

### `Class` Sınıfı
`Class` sınıfı, sınıf bilgilerini içerir. Aşağıdaki özelliklere sahiptir:

- `ClassId`: Sınıfın benzersiz kimliği (int).
- `ClassName`: Sınıfın adı (string).

## Veri Seti

Örnek veri seti olarak, aşağıdaki öğrenci ve sınıf bilgileri kullanılmıştır:

### Öğrenciler

| StudentId | StudentName | ClassId |
|-----------|-------------|---------|
| 1         | Ali         | 1       |
| 2         | Ayşe        | 2       |
| 3         | Mehmet      | 1       |
| 4         | Fatma       | 3       |
| 5         | Ahmet       | 2       |

### Sınıflar

| ClassId | ClassName  |
|---------|------------|
| 1       | Matematik  |
| 2       | Türkçe     |
| 3       | Kimya      |
