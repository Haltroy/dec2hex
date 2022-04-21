namespace DecimalToHex
{
    internal static partial class Translations
    {
        public static string GetError(string loc, int index)
        {
            return loc switch
            {
                "tr" => index switch
                {
                    0 => "Çıkış dosyası konumu boştu.",
                    1 => "Hiç bir argüman girilmemiş.",
                    2 => "Dosya \"{0}\" bulunamadı.",
                    3 => "Giriş argümanı boştu.",
                    _ => "Bilinmeyen hata kodu \"" + index + "\".",
                },
                "af" => index switch
                {
                    0 => "Uitsetpad was leeg.",
                    1 => "Geen argumente gegee nie.",
                    2 => "Lêer \"{0}\" bestaan ​​nie.",
                    3 => "Invoer was leeg.",
                    _ => "Onbekende foutkode \"" + index + "\".",
                },
                "sq" => index switch
                {
                    0 => "Rruga e daljes ishte bosh.",
                    1 => "Asnjë argument i dhënë.",
                    2 => "Skedari \"{0}\" nuk ekziston.",
                    3 => "Hyrja ishte bosh.",
                    _ => "Kodi i panjohur i gabimit \"" + index + "\".",
                },
                "am" => index switch
                {
                    0 => "የውጤት መንገዱ ባዶ ነበር።",
                    1 => "ምንም ክርክሮች አልተሰጡም።",
                    2 => "ፋይል \"{0}\" የለም።",
                    3 => "ግቤት ባዶ ነበር።",
                    _ => "ያልታወቀ የስህተት ኮድ [1]።",
                },
                "ar" => index switch
                {
                    0 => "كان مسار الإخراج فارغًا.",
                    1 => "لا توجد حجج.",
                    2 => "الملف \"{0}\" غير موجود.",
                    3 => "كان الإدخال فارغًا.",
                    _ => "رمز خطأ غير معروف \"" + index + "\".",
                },
                "hy" => index switch
                {
                    0 => "Ելքի ուղին դատարկ էր:",
                    1 => "Փաստարկներ չեն բերվել:",
                    2 => "Ֆայլը \"{0}\" գոյություն չունի:",
                    3 => "Մուտքը դատարկ էր:",
                    _ => "Անհայտ սխալի կոդը \"" + index + "\":",
                },
                "az" => index switch
                {
                    0 => "Çıxış yolu boş idi.",
                    1 => "Heç bir arqument verilməyib.",
                    2 => "\"{0}\" faylı mövcud deyil.",
                    3 => "Daxiletmə boş idi.",
                    _ => "Naməlum xəta kodu \"" + index + "\".",
                },
                "eu" => index switch
                {
                    0 => "Irteerako bidea hutsik zegoen.",
                    1 => "Ez da argudiorik eman.",
                    2 => "\"{0}\" fitxategia ez da existitzen.",
                    3 => "Sarrera hutsik zegoen.",
                    _ => "Errore-kode ezezaguna \"" + index + "\".",
                },
                "be" => index switch
                {
                    0 => "Выхадны шлях быў пусты.",
                    1 => "Аргументаў няма.",
                    2 => "Файл \"{0}\" не існуе.",
                    3 => "Увод быў пусты.",
                    _ => "Невядомы код памылкі \"" + index + "\".",
                },
                "bn" => index switch
                {
                    0 => "আউটপুট পথ খালি ছিল।",
                    1 => "কোন যুক্তি দেওয়া.",
                    2 => "ফাইল \"{0}\" বিদ্যমান নেই।",
                    3 => "ইনপুট খালি ছিল.",
                    _ => "অজানা ত্রুটি কোড \"" + index + "\".",
                },
                "bs" => index switch
                {
                    0 => "Izlazna putanja je bila prazna.",
                    1 => "Nisu dati argumenti.",
                    2 => "Fajl \"{0}\" ne postoji.",
                    3 => "Unos je bio prazan.",
                    _ => "Nepoznati kod greške \"" + index + "\".",
                },
                "bg" => index switch
                {
                    0 => "Изходният път беше празен.",
                    1 => "Не са дадени аргументи.",
                    2 => "Файл \"{0}\" не съществува.",
                    3 => "Въвеждането беше празно.",
                    _ => "Неизвестен код за грешка \"" + index + "\".",
                },
                "ca" => index switch
                {
                    0 => "El camí de sortida estava buit.",
                    1 => "No es donen arguments.",
                    2 => "El fitxer \"{0}\" no existeix.",
                    3 => "L'entrada estava buida.",
                    _ => "Codi d'error desconegut \"" + index + "\".",
                },
                "ceb" => index switch
                {
                    0 => "Ang agianan sa output walay sulod.",
                    1 => "Walay gihatag nga argumento.",
                    2 => "Ang file \"{0}\" wala.",
                    3 => "Walay sulod ang input.",
                    _ => "Wala mailhi nga error code \"" + index + "\".",
                },
                "ny" => index switch
                {
                    0 => "Njira yotulutsa inali yopanda kanthu.",
                    1 => "Palibe zotsutsana zomwe zaperekedwa.",
                    2 => "Fayilo \"{0}\" kulibe.",
                    3 => "Zolowetsa zinali zopanda kanthu.",
                    _ => "Khodi yolakwika yosadziwika \"" + index + "\".",
                },
                "zh-cn" => index switch
                {
                    0 => "输出路径为空。",
                    1 => "没有给出论据。",
                    2 => "文件 \"{0}\" 不存在。",
                    3 => "输入为空。",
                    _ => "未知错误代码 \"" + index + "\"。",
                },
                "zh-tw" => index switch
                {
                    0 => "輸出路徑為空。",
                    1 => "沒有給出論據。",
                    2 => "文件 \"{0}\" 不存在。",
                    3 => "輸入為空。",
                    _ => "未知錯誤代碼 \"" + index + "\"。",
                },
                "co" => index switch
                {
                    0 => "U caminu di output era viotu.",
                    1 => "Nisun argumentu datu.",
                    2 => "U schedariu \"{0}\" ùn esiste micca.",
                    3 => "L'input era viotu.",
                    _ => "Codice d'errore scunnisciutu \"" + index + "\".",
                },
                "hr" => index switch
                {
                    0 => "Izlazni put je bio prazan.",
                    1 => "Nisu navedeni argumenti.",
                    2 => "Datoteka \"{0}\" ne postoji.",
                    3 => "Unos je bio prazan.",
                    _ => "Nepoznati kod pogreške \"" + index + "\".",
                },
                "cs" => index switch
                {
                    0 => "Výstupní cesta byla prázdná.",
                    1 => "Nebyly uvedeny žádné argumenty.",
                    2 => "Soubor \"{0}\" neexistuje.",
                    3 => "Vstup byl prázdný.",
                    _ => "Neznámý kód chyby \"" + index + "\".",
                },
                "da" => index switch
                {
                    0 => "Outputstien var tom.",
                    1 => "Ingen argumenter givet.",
                    2 => "Filen \"{0}\" eksisterer ikke.",
                    3 => "Input var tomt.",
                    _ => "Ukendt fejlkode \"" + index + "\".",
                },
                "nl" => index switch
                {
                    0 => "Uitvoerpad was leeg.",
                    1 => "Geen argumenten gegeven.",
                    2 => "Bestand \"{0}\" bestaat niet.",
                    3 => "Invoer was leeg.",
                    _ => "Onbekende foutcode \"" + index + "\".",
                },
                "eo" => index switch
                {
                    0 => "Eligvojo estis malplena.",
                    1 => "Neniuj argumentoj donitaj.",
                    2 => "Dosiero \"{0}\" ne ekzistas.",
                    3 => "Enigo estis malplena.",
                    _ => "Nekonata erarkodo \"" + index + "\".",
                },
                "et" => index switch
                {
                    0 => "Väljundtee oli tühi.",
                    1 => "Argumente ei esitatud.",
                    2 => "Faili \"{0}\" pole olemas.",
                    3 => "Sisend oli tühi.",
                    _ => "Tundmatu veakood \"" + index + "\".",
                },
                "tl" => index switch
                {
                    0 => "Walang laman ang path ng output.",
                    1 => "Walang ibinigay na argumento.",
                    2 => "Ang file \"{0}\" ay hindi umiiral.",
                    3 => "Walang laman ang input.",
                    _ => "Hindi kilalang error code \"" + index + "\".",
                },
                "fi" => index switch
                {
                    0 => "Lähtöpolku oli tyhjä.",
                    1 => "Ei esitetty argumentteja.",
                    2 => "Tiedostoa \"{0}\" ei ole olemassa.",
                    3 => "Syöte oli tyhjä.",
                    _ => "Tuntematon virhekoodi \"" + index + "\".",
                },
                "fr" => index switch
                {
                    0 => "Le chemin de sortie était vide.",
                    1 => "Aucun argument donné.",
                    2 => "Le fichier \"{0}\" n'existe pas.",
                    3 => "L'entrée était vide.",
                    _ => "Code d'erreur inconnu \"" + index + "\".",
                },
                "fy" => index switch
                {
                    0 => "Utfierpaad wie leech.",
                    1 => "Gjin arguminten jûn.",
                    2 => "Triem \"{0}\" bestiet net.",
                    3 => "Ynfier wie leech.",
                    _ => "Unbekende flaterkoade \"" + index + "\".",
                },
                "gl" => index switch
                {
                    0 => "O camiño de saída estaba baleiro.",
                    1 => "Non se dan argumentos.",
                    2 => "O ficheiro \"{0}\" non existe.",
                    3 => "A entrada estaba baleira.",
                    _ => "Código de erro descoñecido \"" + index + "\".",
                },
                "ka" => index switch
                {
                    0 => "გამომავალი ბილიკი ცარიელი იყო.",
                    1 => "არგუმენტები არ არის მოყვანილი.",
                    2 => "ფაილი \"{0}\" არ არსებობს.",
                    3 => "შენატანი ცარიელი იყო.",
                    _ => "უცნობი შეცდომის კოდი \"" + index + "\".",
                },
                "de" => index switch
                {
                    0 => "Ausgangspfad war leer.",
                    1 => "Keine Argumente angegeben.",
                    2 => "Datei \"{0}\" existiert nicht.",
                    3 => "Eingabe war leer.",
                    _ => "Unbekannter Fehlercode \"" + index + "\".",
                },
                "el" => index switch
                {
                    0 => "Η διαδρομή εξόδου ήταν άδεια.",
                    1 => "Δεν δίνονται επιχειρήματα.",
                    2 => "Το αρχείο \"{0}\" δεν υπάρχει.",
                    3 => "Η είσοδος ήταν άδεια.",
                    _ => "Άγνωστος κωδικός σφάλματος \"" + index + "\".",
                },
                "gu" => index switch
                {
                    0 => "આઉટપુટ પાથ ખાલી હતો.",
                    1 => "કોઈ દલીલો આપવામાં આવી નથી.",
                    2 => "ફાઇલ \"{0}\" અસ્તિત્વમાં નથી.",
                    3 => "ઇનપુટ ખાલી હતું.",
                    _ => "અજ્ઞાત ભૂલ કોડ \"" + index + "\".",
                },
                "ht" => index switch
                {
                    0 => "Chemen Sòti a te vid.",
                    1 => "Pa gen okenn agiman bay.",
                    2 => "Fichye \"{0}\" pa egziste.",
                    3 => "Antre te vid.",
                    _ => "Enkoni kòd erè \"" + index + "\".",
                },
                "ha" => index switch
                {
                    0 => "Hanyar fitarwa babu kowa.",
                    1 => "Ba a bayar da hujja ba.",
                    2 => "Babu fayil \"{0}\".",
                    3 => "Shigar babu kowa.",
                    _ => "Lambar kuskuren da ba a sani ba \"" + index + "\".",
                },
                "haw" => index switch
                {
                    0 => "Ua hakahaka ke ala puka.",
                    1 => "ʻAʻohe hoʻopaʻapaʻa i hāʻawi ʻia.",
                    2 => "ʻAʻohe waihona \"{0}\".",
                    3 => "Ua nele ka hookomo.",
                    _ => "Ka helu kuhi hewa ʻike ʻole \"" + index + "\".",
                },
                "iw" => index switch
                {
                    0 => "נתיב הפלט היה ריק.",
                    1 => "לא ניתנו טיעונים.",
                    2 => "הקובץ \"{0}\" אינו קיים.",
                    3 => "הקלט היה ריק.",
                    _ => "קוד שגיאה לא ידוע \"" + index + "\".",
                },
                "he" => index switch
                {
                    0 => "נתיב הפלט היה ריק.",
                    1 => "לא ניתנו טיעונים.",
                    2 => "הקובץ \"{0}\" אינו קיים.",
                    3 => "הקלט היה ריק.",
                    _ => "קוד שגיאה לא ידוע \"" + index + "\".",
                },
                "hi" => index switch
                {
                    0 => "आउटपुट पथ खाली था।",
                    1 => "कोई तर्क नहीं दिया।",
                    2 => "फ़ाइल \"{0}\" मौजूद नहीं है।",
                    3 => "इनपुट खाली था।",
                    _ => "अज्ञात त्रुटि कोड \"" + index + "\"।",
                },
                "hmn" => index switch
                {
                    0 => "Txoj kev tso zis yog khoob.",
                    1 => "Tsis muaj kev sib cav muab.",
                    2 => "Cov ntaub ntawv \"{0}\" tsis muaj.",
                    3 => "Cov tswv yim yog khoob.",
                    _ => "Unknown yuam kev code \"" + index + "\".",
                },
                "hu" => index switch
                {
                    0 => "A kimeneti útvonal üres volt.",
                    1 => "Nincsenek érvek.",
                    2 => "A \"{0}\" fájl nem létezik.",
                    3 => "A bevitel üres volt.",
                    _ => "Ismeretlen hibakód \"" + index + "\".",
                },
                "is" => index switch
                {
                    0 => "Úttaksslóð var tóm.",
                    1 => "Engin rök færð.",
                    2 => "Skrá \"{0}\" er ekki til.",
                    3 => "Inntak var tómt.",
                    _ => "Óþekktur villukóði \"" + index + "\".",
                },
                "ig" => index switch
                {
                    0 => "Ụzọ mmepụta tọgbọrọ chakoo.",
                    1 => "Enweghị arụmụka nyere.",
                    2 => "Faịlụ \"{0}\" adịghị.",
                    3 => "Ntinye adịghị.",
                    _ => "Koodu mperi amaghi ama \"" + index + "\".",
                },
                "id" => index switch
                {
                    0 => "Jalur keluaran kosong.",
                    1 => "Tidak ada argumen yang diberikan.",
                    2 => "Berkas \"{0}\" tidak ada.",
                    3 => "Masukan kosong.",
                    _ => "Kode kesalahan tidak diketahui \"" + index + "\".",
                },
                "ga" => index switch
                {
                    0 => "Bhí cosán aschuir folamh.",
                    1 => "Níor tugadh aon argóintí.",
                    2 => "Níl comhad \"{0}\" ann.",
                    3 => "Bhí an t-ionchur folamh.",
                    _ => "Cód earráide anaithnid \"" + index + "\".",
                },
                "it" => index switch
                {
                    0 => "Il percorso di output era vuoto.",
                    1 => "Nessun argomento fornito.",
                    2 => "Il file \"{0}\" non esiste.",
                    3 => "L'input era vuoto.",
                    _ => "Codice di errore sconosciuto \"" + index + "\".",
                },
                "ja" => index switch
                {
                    0 => "出力パスが空でした。",
                    1 => "引数はありません。",
                    2 => "ファイル\"{0}\"は存在しません。",
                    3 => "入力が空でした。",
                    _ => "不明なエラーコード\"" + index + "\"。",
                },
                "jw" => index switch
                {
                    0 => "Jalur output kosong.",
                    1 => "Ora ana bantahan sing diwenehake.",
                    2 => "File \"{0}\" ora ana.",
                    3 => "Input kosong.",
                    _ => "Kode kesalahan sing ora dingerteni \"" + index + "\".",
                },
                "kn" => index switch
                {
                    0 => "ಔಟ್‌ಪುಟ್ ಮಾರ್ಗ ಖಾಲಿಯಾಗಿತ್ತು.",
                    1 => "ಯಾವುದೇ ವಾದಗಳನ್ನು ನೀಡಲಾಗಿಲ್ಲ.",
                    2 => "ಫೈಲ್ \"{0}\" ಅಸ್ತಿತ್ವದಲ್ಲಿಲ್ಲ.",
                    3 => "ಇನ್‌ಪುಟ್ ಖಾಲಿಯಾಗಿತ್ತು.",
                    _ => "ಅಜ್ಞಾತ ದೋಷ ಕೋಡ್ \"" + index + "\".",
                },
                "kk" => index switch
                {
                    0 => "Шығару жолы бос болды.",
                    1 => "Аргументтер келтірілмеген.",
                    2 => "\"{0}\" файлы жоқ.",
                    3 => "Енгізу бос болды.",
                    _ => "Белгісіз қате коды \"" + index + "\".",
                },
                "km" => index switch
                {
                    0 => "ផ្លូវចេញគឺទទេ។",
                    1 => "មិនបានផ្តល់អំណះអំណាងទេ។",
                    2 => "ឯកសារ \"{0}\" មិនមានទេ។",
                    3 => "ការបញ្ចូលគឺទទេ។",
                    _ => "មិនស្គាល់លេខកូដកំហុស \"" + index + "\" ។",
                },
                "ko" => index switch
                {
                    0 => "출력 경로가 비어 있습니다.",
                    1 => "인수가 없습니다.",
                    2 => "파일 \"{0}\"이(가) 존재하지 않습니다.",
                    3 => "입력이 비어 있습니다.",
                    _ => "알 수 없는 오류 코드\"" + index + "\".",
                },
                "ku" => index switch
                {
                    0 => "Rêya derketinê vala bû.",
                    1 => "Tu argûman nehat dayîn.",
                    2 => "Pela \"{0}\" tune.",
                    3 => "Ketin vala bû.",
                    _ => "Koda xeletiya nenas \"" + index + "\".",
                },
                "ky" => index switch
                {
                    0 => "Чыгуу жолу бош болчу.",
                    1 => "Аргументтер келтирилген жок.",
                    2 => "\"{0}\" файлы жок.",
                    3 => "Киргизүү бош болчу.",
                    _ => "Белгисиз ката коду \"" + index + "\".",
                },
                "lo" => index switch
                {
                    0 => "ເສັ້ນທາງອອກແມ່ນຫວ່າງເປົ່າ.",
                    1 => "ບໍ່ມີການໂຕ້ຖຽງໃຫ້.",
                    2 => "ໄຟລ໌ \"{0}\" ບໍ່ມີ.",
                    3 => "ການປ້ອນຂໍ້ມູນຫວ່າງເປົ່າ.",
                    _ => "ລະຫັດຂໍ້ຜິດພາດທີ່ບໍ່ຮູ້ຈັກ \"" + index + "\".",
                },
                "la" => index switch
                {
                    0 => "Semita inanis erat output.",
                    1 => "Nullae rationes dantur.",
                    2 => "Tabularium \"{0}\" non exstat.",
                    3 => "Input vacua erat.",
                    _ => "Error ignoti codicis \"" + index + "\".",
                },
                "lv" => index switch
                {
                    0 => "Izvades ceļš bija tukšs.",
                    1 => "Argumenti nav sniegti.",
                    2 => "Fails \"{0}\" neeksistē.",
                    3 => "Ievade bija tukša.",
                    _ => "Nezināms kļūdas kods \"" + index + "\".",
                },
                "lt" => index switch
                {
                    0 => "Išvesties kelias buvo tuščias.",
                    1 => "Argumentų nepateikta.",
                    2 => "Failas \"{0}\" neegzistuoja.",
                    3 => "Įvestis buvo tuščia.",
                    _ => "Nežinomas klaidos kodas \"" + index + "\".",
                },
                "lb" => index switch
                {
                    0 => "Ausgangswee war eidel.",
                    1 => "Keng Argumenter ginn.",
                    2 => "De Fichier \"{0}\" gëtt et net.",
                    3 => "Input war eidel.",
                    _ => "Onbekannte Feelercode \"" + index + "\".",
                },
                "mk" => index switch
                {
                    0 => "Излезната патека беше празна.",
                    1 => "Не се дадени аргументи.",
                    2 => "Датотеката \"{0}\" не постои.",
                    3 => "Влезот беше празен.",
                    _ => "Непознат код за грешка \"" + index + "\".",
                },
                "mg" => index switch
                {
                    0 => "Foana ny lalan'ny fivoahana.",
                    1 => "Tsy misy tohan-kevitra omena.",
                    2 => "Tsy misy ny rakitra \"{0}\".",
                    3 => "Foana ny fidirana.",
                    _ => "Kaody fahadisoana tsy fantatra \"" + index + "\".",
                },
                "ms" => index switch
                {
                    0 => "Laluan output kosong.",
                    1 => "Tiada hujah diberikan.",
                    2 => "Fail \"{0}\" tidak wujud.",
                    3 => "Input kosong.",
                    _ => "Kod ralat tidak diketahui \"" + index + "\".",
                },
                "ml" => index switch
                {
                    0 => "ഔട്ട്പുട്ട് പാത ശൂന്യമായിരുന്നു.",
                    1 => "വാദങ്ങളൊന്നും നൽകിയിട്ടില്ല.",
                    2 => "ഫയൽ \"{0}\" നിലവിലില്ല.",
                    3 => "ഇൻപുട്ട് ശൂന്യമായിരുന്നു.",
                    _ => "അജ്ഞാത പിശക് കോഡ് \"" + index + "\".",
                },
                "mt" => index switch
                {
                    0 => "Il-mogħdija tal-ħruġ kienet vojta.",
                    1 => "Ebda argumenti mogħtija.",
                    2 => "Il-fajl \"{0}\" ma jeżistix.",
                    3 => "L-input kien vojt.",
                    _ => "Kodiċi ta' żball mhux magħruf \"" + index + "\".",
                },
                "mi" => index switch
                {
                    0 => "I putua te ara putanga.",
                    1 => "Karekau he tautohetohe.",
                    2 => "Ko te konae \"{0}\" karekau.",
                    3 => "I putua te whakauru.",
                    _ => "Waehere hapa kore mohiotia \"" + index + "\".",
                },
                "mr" => index switch
                {
                    0 => "आउटपुट मार्ग रिकामा होता.",
                    1 => "कोणतेही युक्तिवाद दिले नाहीत.",
                    2 => "फाइल \"{0}\" अस्तित्वात नाही.",
                    3 => "इनपुट रिकामे होते.",
                    _ => "अज्ञात त्रुटी कोड [१].",
                },
                "mn" => index switch
                {
                    0 => "Гаралтын зам хоосон байсан.",
                    1 => "Аргумент өгөөгүй.",
                    2 => "\"{0}\" файл байхгүй байна.",
                    3 => "Оруулга хоосон байсан.",
                    _ => "Үл мэдэгдэх алдааны код \"" + index + "\".",
                },
                "my" => index switch
                {
                    0 => "အထွက်လမ်းကြောင်းသည် ဗလာဖြစ်နေသည်။",
                    1 => "အငြင်းအခုံတွေ မပေးဘူး။",
                    2 => "ဖိုင် \"{0}\" မရှိပါ။",
                    3 => "ထည့်သွင်းမှုသည် ဗလာဖြစ်နေသည်။",
                    _ => "အမည်မသိ အမှားကုဒ် \"" + index + "\"။",
                },
                "ne" => index switch
                {
                    0 => "आउटपुट मार्ग खाली थियो।",
                    1 => "कुनै तर्क दिइएको छैन।",
                    2 => "फाइल \"{0}\" अवस्थित छैन।",
                    3 => "इनपुट खाली थियो।",
                    _ => "अज्ञात त्रुटि कोड [१]।",
                },
                "no" => index switch
                {
                    0 => "Utdatabanen var tom.",
                    1 => "Ingen argumenter gitt.",
                    2 => "Filen \"{0}\" eksisterer ikke.",
                    3 => "Inndata var tomt.",
                    _ => "Ukjent feilkode \"" + index + "\".",
                },
                "or" => index switch
                {
                    0 => "ଆଉଟପୁଟ୍ ପଥ ଖାଲି ଥିଲା |",
                    1 => "କ arg ଣସି ଯୁକ୍ତି ଦିଆଯାଇ ନାହିଁ |",
                    2 => "ଫାଇଲ୍ \"{0}\" ବିଦ୍ୟମାନ ନାହିଁ |",
                    3 => "ଇନପୁଟ୍ ଖାଲି ଥିଲା |",
                    _ => "ଅଜ୍ଞାତ ତ୍ରୁଟି ସଂକେତ \"" + index + "\" |",
                },
                "ps" => index switch
                {
                    0 => "د محصول لاره خالي وه.",
                    1 => "هیڅ دلیل نه دی ورکړل شوی.",
                    2 => "دوتنه \"{0}\" شتون نلري.",
                    3 => "داخله خالي وه.",
                    _ => "د نامعلومې تېروتنې کوډ \"" + index + "\".",
                },
                "fa" => index switch
                {
                    0 => "مسیر خروجی خالی بود",
                    1 => "هیچ استدلالی ارائه نشده است.",
                    2 => "فایل \"{0}\" وجود ندارد.",
                    3 => "ورودی خالی بود",
                    _ => "کد خطای ناشناخته \"" + index + "\".",
                },
                "pl" => index switch
                {
                    0 => "Ścieżka wyjściowa była pusta.",
                    1 => "Nie podano argumentów.",
                    2 => "Plik \"{0}\" nie istnieje.",
                    3 => "Wejście było puste.",
                    _ => "Nieznany kod błędu \"" + index + "\".",
                },
                "pt" => index switch
                {
                    0 => "O caminho de saída estava vazio.",
                    1 => "Nenhum argumento dado.",
                    2 => "O arquivo \"{0}\" não existe.",
                    3 => "A entrada estava vazia.",
                    _ => "Código de erro desconhecido \"" + index + "\".",
                },
                "pa" => index switch
                {
                    0 => "ਆਉਟਪੁੱਟ ਮਾਰਗ ਖਾਲੀ ਸੀ।",
                    1 => "ਕੋਈ ਦਲੀਲ ਨਹੀਂ ਦਿੱਤੀ ਗਈ।",
                    2 => "ਫ਼ਾਈਲ \"{0}\" ਮੌਜੂਦ ਨਹੀਂ ਹੈ।",
                    3 => "ਇਨਪੁਟ ਖਾਲੀ ਸੀ।",
                    _ => "ਅਗਿਆਤ ਗਲਤੀ ਕੋਡ \"" + index + "\"।",
                },
                "ro" => index switch
                {
                    0 => "Calea de ieșire era goală.",
                    1 => "Nu se dau argumente.",
                    2 => "Fișierul \"{0}\" nu există.",
                    3 => "Intrarea a fost goală.",
                    _ => "Cod de eroare necunoscut \"" + index + "\".",
                },
                "ru" => index switch
                {
                    0 => "Выходной путь был пуст.",
                    1 => "Аргументы не приведены.",
                    2 => "Файл \"{0}\" не существует.",
                    3 => "Вход был пуст.",
                    _ => "Неизвестный код ошибки \"" + index + "\".",
                },
                "sm" => index switch
                {
                    0 => "Sa gaogao le auala e maua mai ai.",
                    1 => "Leai ni finauga na tuuina mai.",
                    2 => "E leai se faila \"{0}\".",
                    3 => "Sa gaogao mea e maua.",
                    _ => "Faailoga sese e le iloa \"" + index + "\".",
                },
                "gd" => index switch
                {
                    0 => "Bha slighe toraidh falamh.",
                    1 => "Cha deach argamaidean a thoirt seachad.",
                    2 => "Chan eil faidhle \"{0}\" ann.",
                    3 => "Bha an cuir a-steach falamh.",
                    _ => "Còd na mearachd neo-aithnichte \"" + index + "\".",
                },
                "sr" => index switch
                {
                    0 => "Излазна путања је била празна.",
                    1 => "Нису дати аргументи.",
                    2 => "Фајл \"{0}\" не постоји.",
                    3 => "Унос је био празан.",
                    _ => "Непознати код грешке \"" + index + "\".",
                },
                "st" => index switch
                {
                    0 => "Tsela ea ho tsoa e ne e se na letho.",
                    1 => "Ha ho likhang tse fanoeng.",
                    2 => "Faele \"{0}\" ha e eo.",
                    3 => "Kenyo e ne e se na letho.",
                    _ => "Khoutu ea phoso e sa tsejoeng \"" + index + "\".",
                },
                "sn" => index switch
                {
                    0 => "Nzira yekubuda nayo yanga isina chinhu.",
                    1 => "Hapana nharo dzakapihwa.",
                    2 => "Faira \"{0}\" haipo.",
                    3 => "Zvekuisa paive pasina.",
                    _ => "Kodhi yekukanganisa isingazivikanwe \"" + index + "\".",
                },
                "sd" => index switch
                {
                    0 => "ٻاھر نڪرڻ وارو رستو خالي ھو.",
                    1 => "ڪوبه دليل نه ڏنو ويو.",
                    2 => "فائل \"{0}\" موجود ناهي.",
                    3 => "ان پٽ خالي هو.",
                    _ => "اڻڄاتل غلطي ڪوڊ \"" + index + "\".",
                },
                "si" => index switch
                {
                    0 => "ප්‍රතිදාන මාර්ගය හිස් විය.",
                    1 => "තර්ක ඉදිරිපත් කර නැත.",
                    2 => "\"{0}\" ගොනුව නොපවතී.",
                    3 => "ආදානය හිස් විය.",
                    _ => "නොදන්නා දෝෂ කේතය \"" + index + "\".",
                },
                "sk" => index switch
                {
                    0 => "Výstupná cesta bola prázdna.",
                    1 => "Neboli uvedené žiadne argumenty.",
                    2 => "Súbor \"{0}\" neexistuje.",
                    3 => "Vstup bol prázdny.",
                    _ => "Neznámy kód chyby \"" + index + "\".",
                },
                "sl" => index switch
                {
                    0 => "Izhodna pot je bila prazna.",
                    1 => "Nobenih argumentov ni podanih.",
                    2 => "Datoteka \"{0}\" ne obstaja.",
                    3 => "Vnos je bil prazen.",
                    _ => "Neznana koda napake \"" + index + "\".",
                },
                "so" => index switch
                {
                    0 => "Waddada wax-soo-saarka ayaa madhnayd.",
                    1 => "Wax dood ah lama siin.",
                    2 => "Faylka \"{0}\" ma jiro.",
                    3 => "Gelintu way madhnayd",
                    _ => "Koodhka khaladka aan la garanayn \"" + index + "\".",
                },
                "es" => index switch
                {
                    0 => "La ruta de salida estaba vacía.",
                    1 => "No se dan argumentos.",
                    2 => "El archivo \"{0}\" no existe.",
                    3 => "La entrada estaba vacía.",
                    _ => "Código de error desconocido \"" + index + "\".",
                },
                "su" => index switch
                {
                    0 => "Jalur kaluaran kosong.",
                    1 => "Taya argumen dibikeun.",
                    2 => "File \"{0}\" teu aya.",
                    3 => "Input kosong.",
                    _ => "Kode kasalahan anu teu dipikanyaho \"" + index + "\".",
                },
                "sw" => index switch
                {
                    0 => "Njia ya pato ilikuwa tupu.",
                    1 => "Hakuna hoja zilizotolewa.",
                    2 => "Faili \"{0}\" haipo.",
                    3 => "Ingizo lilikuwa tupu.",
                    _ => "Msimbo wa hitilafu usiojulikana \"" + index + "\".",
                },
                "sv" => index switch
                {
                    0 => "Utdatasökvägen var tom.",
                    1 => "Inga argument angivna.",
                    2 => "Filen \"{0}\" finns inte.",
                    3 => "Ingången var tom.",
                    _ => "Okänd felkod \"" + index + "\".",
                },
                "tg" => index switch
                {
                    0 => "Роҳи баромад холӣ буд.",
                    1 => "Ҳеҷ далеле оварда нашудааст.",
                    2 => "Файл \"{0}\" вуҷуд надорад.",
                    3 => "Вуруд холӣ буд.",
                    _ => "Рамзи хатои номаълум \"" + index + "\".",
                },
                "ta" => index switch
                {
                    0 => "வெளியீட்டு பாதை காலியாக இருந்தது.",
                    1 => "வாதங்கள் எதுவும் கொடுக்கப்படவில்லை.",
                    2 => "கோப்பு \"{0}\" இல்லை.",
                    3 => "உள்ளீடு காலியாக இருந்தது.",
                    _ => "அறியப்படாத பிழைக் குறியீடு \"" + index + "\".",
                },
                "te" => index switch
                {
                    0 => "అవుట్‌పుట్ మార్గం ఖాళీగా ఉంది.",
                    1 => "వాదనలు ఇవ్వలేదు.",
                    2 => "ఫైల్ \"{0}\" ఉనికిలో లేదు.",
                    3 => "ఇన్‌పుట్ ఖాళీగా ఉంది.",
                    _ => "తెలియని ఎర్రర్ కోడ్ \"" + index + "\".",
                },
                "th" => index switch
                {
                    0 => "เส้นทางเอาต์พุตว่างเปล่า",
                    1 => "ไม่มีอาร์กิวเมนต์ให้",
                    2 => "ไม่มีไฟล์ \"{0}\"",
                    3 => "อินพุตว่างเปล่า",
                    _ => "รหัสข้อผิดพลาดที่ไม่รู้จัก \"" + index + "\"",
                },
                "uk" => index switch
                {
                    0 => "Вихідний шлях був порожнім.",
                    1 => "Аргументів не надано.",
                    2 => "Файл \"{0}\" не існує.",
                    3 => "Введення було порожнім.",
                    _ => "Невідомий код помилки \"" + index + "\".",
                },
                "ur" => index switch
                {
                    0 => "آؤٹ پٹ پاتھ خالی تھا۔",
                    1 => "کوئی دلائل نہیں دیے گئے۔",
                    2 => "فائل \"{0}\" موجود نہیں ہے۔",
                    3 => "ان پٹ خالی تھا۔",
                    _ => "نامعلوم غلطی کا کوڈ \"" + index + "\"۔",
                },
                "ug" => index switch
                {
                    0 => "چىقىش يولى قۇرۇق ئىدى.",
                    1 => "ھېچقانداق دەلىل يوق.",
                    2 => "ھۆججەت \"{0}\" مەۋجۇت ئەمەس.",
                    3 => "كىرگۈزۈش قۇرۇق ئىدى.",
                    _ => "نامەلۇم خاتالىق كودى \"" + index + "\".",
                },
                "uz" => index switch
                {
                    0 => "Chiqish yoʻli boʻsh edi.",
                    1 => "Hech qanday dalil keltirilmagan.",
                    2 => "\"{0}\" fayli mavjud emas.",
                    3 => "Kirish boʻsh edi.",
                    _ => "Noma'lum xato kodi \"" + index + "\".",
                },
                "vi" => index switch
                {
                    0 => "Đường dẫn đầu ra trống.",
                    1 => "Không có đối số nào được đưa ra.",
                    2 => "Tệp \"{0}\" không tồn tại.",
                    3 => "Đầu vào trống.",
                    _ => "Mã lỗi không xác định \"" + index + "\".",
                },
                "cy" => index switch
                {
                    0 => "Roedd y llwybr allbwn yn wag.",
                    1 => "Dim dadleuon wedi'u rhoi.",
                    2 => "Nid yw ffeil \"{0}\" yn bodoli.",
                    3 => "Roedd y mewnbwn yn wag.",
                    _ => "Cod gwall anhysbys \"" + index + "\".",
                },
                "xh" => index switch
                {
                    0 => "Indlela yemveliso ibingenanto.",
                    1 => "Akukho zimpikiswano zinikiweyo.",
                    2 => "Ifayile \"{0}\" ayikho.",
                    3 => "Ungeniso belungenanto.",
                    _ => "Ikhowudi yempazamo engaziwayo \"" + index + "\".",
                },
                "yi" => index switch
                {
                    0 => "רעזולטאַט דרך איז געווען ליידיק.",
                    1 => "קיין טענות נישט געגעבן.",
                    2 => "טעקע \"{0}\" טוט נישט עקסיסטירן.",
                    3 => "אַרייַנשרייַב איז געווען ליידיק.",
                    _ => "אומבאַקאַנט טעות קאָד \"" + index + "\".",
                },
                "yo" => index switch
                {
                    0 => "Ọ̀nà àbájáde ṣófo.",
                    1 => "Ko si awọn ariyanjiyan ti a fun.",
                    2 => "Faili \"{0}\" ko si.",
                    3 => "Iṣawọle ti ṣofo.",
                    _ => "Aṣiṣe koodu aimọ \"" + index + "\".",
                },
                "zu" => index switch
                {
                    0 => "Indlela yokuphuma ibingenalutho.",
                    1 => "Azikho izimpikiswano ezinikeziwe.",
                    2 => "Ifayela \"{0}\" alikho.",
                    3 => "Okokufaka bekungenalutho.",
                    _ => "Ikhodi yephutha engaziwa \"" + index + "\".",
                },
                _ => index switch
                {
                    0 => "Output path was empty.",
                    1 => "No arguments given.",
                    2 => "File \"{0}\" does not exists.",
                    3 => "Input was empty.",
                    _ => "Unknown error code \"" + index + "\".",
                },
            };
        }
    }
}