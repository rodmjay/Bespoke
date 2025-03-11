using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResumePro.Infrastructure.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Iso2", "CapsName", "Iso3", "Name", "NumberCode", "PhoneCode" },
                values: new object[,]
                {
                    { "AD", "ANDORRA", "AND", "Andorra", 20, 376 },
                    { "AE", "UNITED ARAB EMIRATES", "ARE", "United Arab Emirates", 784, 971 },
                    { "AF", "AFGHANISTAN", "AFG", "Afghanistan", 4, 93 },
                    { "AG", "ANTIGUA AND BARBUDA", "ATG", "Antigua and Barbuda", 28, 1268 },
                    { "AI", "ANGUILLA", "AIA", "Anguilla", 660, 1264 },
                    { "AL", "ALBANIA", "ALB", "Albania", 8, 355 },
                    { "AM", "ARMENIA", "ARM", "Armenia", 51, 374 },
                    { "AN", "NETHERLANDS ANTILLES", "ANT", "Netherlands Antilles", 530, 599 },
                    { "AO", "ANGOLA", "AGO", "Angola", 24, 244 },
                    { "AQ", "ANTARCTICA", "", "Antarctica", null, 0 },
                    { "AR", "ARGENTINA", "ARG", "Argentina", 32, 54 },
                    { "AS", "AMERICAN SAMOA", "ASM", "American Samoa", 16, 1684 },
                    { "AT", "AUSTRIA", "AUT", "Austria", 40, 43 },
                    { "AU", "AUSTRALIA", "AUS", "Australia", 36, 61 },
                    { "AW", "ARUBA", "ABW", "Aruba", 533, 297 },
                    { "AZ", "AZERBAIJAN", "AZE", "Azerbaijan", 31, 994 },
                    { "BA", "BOSNIA AND HERZEGOVINA", "BIH", "Bosnia and Herzegovina", 70, 387 },
                    { "BB", "BARBADOS", "BRB", "Barbados", 52, 1246 },
                    { "BD", "BANGLADESH", "BGD", "Bangladesh", 50, 880 },
                    { "BE", "BELGIUM", "BEL", "Belgium", 56, 32 },
                    { "BF", "BURKINA FASO", "BFA", "Burkina Faso", 854, 226 },
                    { "BG", "BULGARIA", "BGR", "Bulgaria", 100, 359 },
                    { "BH", "BAHRAIN", "BHR", "Bahrain", 48, 973 },
                    { "BI", "BURUNDI", "BDI", "Burundi", 108, 257 },
                    { "BJ", "BENIN", "BEN", "Benin", 204, 229 },
                    { "BM", "BERMUDA", "BMU", "Bermuda", 60, 1441 },
                    { "BN", "BRUNEI DARUSSALAM", "BRN", "Brunei Darussalam", 96, 673 },
                    { "BO", "BOLIVIA", "BOL", "Bolivia", 68, 591 },
                    { "BR", "BRAZIL", "BRA", "Brazil", 76, 55 },
                    { "BS", "BAHAMAS", "BHS", "Bahamas", 44, 1242 },
                    { "BT", "BHUTAN", "BTN", "Bhutan", 64, 975 },
                    { "BV", "BOUVET ISLAND", "", "Bouvet Island", null, 0 },
                    { "BW", "BOTSWANA", "BWA", "Botswana", 72, 267 },
                    { "BY", "BELARUS", "BLR", "Belarus", 112, 375 },
                    { "BZ", "BELIZE", "BLZ", "Belize", 84, 501 },
                    { "CA", "CANADA", "CAN", "Canada", 124, 1 },
                    { "CC", "COCOS (KEELING) ISLANDS", "", "Cocos (Keeling) Islands", null, 672 },
                    { "CD", "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "COD", "Congo, the Democratic Republic of the", 180, 242 },
                    { "CF", "CENTRAL AFRICAN REPUBLIC", "CAF", "Central African Republic", 140, 236 },
                    { "CG", "CONGO", "COG", "Congo", 178, 242 },
                    { "CH", "SWITZERLAND", "CHE", "Switzerland", 756, 41 },
                    { "CI", "COTE D'IVOIRE", "CIV", "Cote D'Ivoire", 384, 225 },
                    { "CK", "COOK ISLANDS", "COK", "Cook Islands", 184, 682 },
                    { "CL", "CHILE", "CHL", "Chile", 152, 56 },
                    { "CM", "CAMEROON", "CMR", "Cameroon", 120, 237 },
                    { "CN", "CHINA", "CHN", "China", 156, 86 },
                    { "CO", "COLOMBIA", "COL", "Colombia", 170, 57 },
                    { "CR", "COSTA RICA", "CRI", "Costa Rica", 188, 506 },
                    { "CS", "SERBIA AND MONTENEGRO", "", "Serbia and Montenegro", null, 381 },
                    { "CU", "CUBA", "CUB", "Cuba", 192, 53 },
                    { "CV", "CAPE VERDE", "CPV", "Cape Verde", 132, 238 },
                    { "CX", "CHRISTMAS ISLAND", "", "Christmas Island", null, 61 },
                    { "CY", "CYPRUS", "CYP", "Cyprus", 196, 357 },
                    { "CZ", "CZECH REPUBLIC", "CZE", "Czech Republic", 203, 420 },
                    { "DE", "GERMANY", "DEU", "Germany", 276, 49 },
                    { "DJ", "DJIBOUTI", "DJI", "Djibouti", 262, 253 },
                    { "DK", "DENMARK", "DNK", "Denmark", 208, 45 },
                    { "DM", "DOMINICA", "DMA", "Dominica", 212, 1767 },
                    { "DO", "DOMINICAN REPUBLIC", "DOM", "Dominican Republic", 214, 1809 },
                    { "DZ", "ALGERIA", "DZA", "Algeria", 12, 213 },
                    { "EC", "ECUADOR", "ECU", "Ecuador", 218, 593 },
                    { "EE", "ESTONIA", "EST", "Estonia", 233, 372 },
                    { "EG", "EGYPT", "EGY", "Egypt", 818, 20 },
                    { "EH", "WESTERN SAHARA", "ESH", "Western Sahara", 732, 212 },
                    { "ER", "ERITREA", "ERI", "Eritrea", 232, 291 },
                    { "ES", "SPAIN", "ESP", "Spain", 724, 34 },
                    { "ET", "ETHIOPIA", "ETH", "Ethiopia", 231, 251 },
                    { "FI", "FINLAND", "FIN", "Finland", 246, 358 },
                    { "FJ", "FIJI", "FJI", "Fiji", 242, 679 },
                    { "FK", "FALKLAND ISLANDS (MALVINAS)", "FLK", "Falkland Islands (Malvinas)", 238, 500 },
                    { "FM", "MICRONESIA, FEDERATED STATES OF", "FSM", "Micronesia, Federated States of", 583, 691 },
                    { "FO", "FAROE ISLANDS", "FRO", "Faroe Islands", 234, 298 },
                    { "FR", "FRANCE", "FRA", "France", 250, 33 },
                    { "GA", "GABON", "GAB", "Gabon", 266, 241 },
                    { "GB", "UNITED KINGDOM", "GBR", "United Kingdom", 826, 44 },
                    { "GD", "GRENADA", "GRD", "Grenada", 308, 1473 },
                    { "GE", "GEORGIA", "GEO", "Georgia", 268, 995 },
                    { "GF", "FRENCH GUIANA", "GUF", "French Guiana", 254, 594 },
                    { "GH", "GHANA", "GHA", "Ghana", 288, 233 },
                    { "GI", "GIBRALTAR", "GIB", "Gibraltar", 292, 350 },
                    { "GL", "GREENLAND", "GRL", "Greenland", 304, 299 },
                    { "GM", "GAMBIA", "GMB", "Gambia", 270, 220 },
                    { "GN", "GUINEA", "GIN", "Guinea", 324, 224 },
                    { "GP", "GUADELOUPE", "GLP", "Guadeloupe", 312, 590 },
                    { "GQ", "EQUATORIAL GUINEA", "GNQ", "Equatorial Guinea", 226, 240 },
                    { "GR", "GREECE", "GRC", "Greece", 300, 30 },
                    { "GS", "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "", "South Georgia and the South Sandwich Islands", null, 0 },
                    { "GT", "GUATEMALA", "GTM", "Guatemala", 320, 502 },
                    { "GU", "GUAM", "GUM", "Guam", 316, 1671 },
                    { "GW", "GUINEA-BISSAU", "GNB", "Guinea-Bissau", 624, 245 },
                    { "GY", "GUYANA", "GUY", "Guyana", 328, 592 },
                    { "HK", "HONG KONG", "HKG", "Hong Kong", 344, 852 },
                    { "HM", "HEARD ISLAND AND MCDONALD ISLANDS", "", "Heard Island and Mcdonald Islands", null, 0 },
                    { "HN", "HONDURAS", "HND", "Honduras", 340, 504 },
                    { "HR", "CROATIA", "HRV", "Croatia", 191, 385 },
                    { "HT", "HAITI", "HTI", "Haiti", 332, 509 },
                    { "HU", "HUNGARY", "HUN", "Hungary", 348, 36 },
                    { "ID", "INDONESIA", "IDN", "Indonesia", 360, 62 },
                    { "IE", "IRELAND", "IRL", "Ireland", 372, 353 },
                    { "IL", "ISRAEL", "ISR", "Israel", 376, 972 },
                    { "IN", "INDIA", "IND", "India", 356, 91 },
                    { "IO", "BRITISH INDIAN OCEAN TERRITORY", "", "British Indian Ocean Territory", null, 246 },
                    { "IQ", "IRAQ", "IRQ", "Iraq", 368, 964 },
                    { "IR", "IRAN, ISLAMIC REPUBLIC OF", "IRN", "Iran, Islamic Republic of", 364, 98 },
                    { "IS", "ICELAND", "ISL", "Iceland", 352, 354 },
                    { "IT", "ITALY", "ITA", "Italy", 380, 39 },
                    { "JM", "JAMAICA", "JAM", "Jamaica", 388, 1876 },
                    { "JO", "JORDAN", "JOR", "Jordan", 400, 962 },
                    { "JP", "JAPAN", "JPN", "Japan", 392, 81 },
                    { "KE", "KENYA", "KEN", "Kenya", 404, 254 },
                    { "KG", "KYRGYZSTAN", "KGZ", "Kyrgyzstan", 417, 996 },
                    { "KH", "CAMBODIA", "KHM", "Cambodia", 116, 855 },
                    { "KI", "KIRIBATI", "KIR", "Kiribati", 296, 686 },
                    { "KM", "COMOROS", "COM", "Comoros", 174, 269 },
                    { "KN", "SAINT KITTS AND NEVIS", "KNA", "Saint Kitts and Nevis", 659, 1869 },
                    { "KP", "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "PRK", "Korea, Democratic People's Republic of", 408, 850 },
                    { "KR", "KOREA, REPUBLIC OF", "KOR", "Korea, Republic of", 410, 82 },
                    { "KW", "KUWAIT", "KWT", "Kuwait", 414, 965 },
                    { "KY", "CAYMAN ISLANDS", "CYM", "Cayman Islands", 136, 1345 },
                    { "KZ", "KAZAKHSTAN", "KAZ", "Kazakhstan", 398, 7 },
                    { "LA", "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LAO", "Lao People's Democratic Republic", 418, 856 },
                    { "LB", "LEBANON", "LBN", "Lebanon", 422, 961 },
                    { "LC", "SAINT LUCIA", "LCA", "Saint Lucia", 662, 1758 },
                    { "LI", "LIECHTENSTEIN", "LIE", "Liechtenstein", 438, 423 },
                    { "LK", "SRI LANKA", "LKA", "Sri Lanka", 144, 94 },
                    { "LR", "LIBERIA", "LBR", "Liberia", 430, 231 },
                    { "LS", "LESOTHO", "LSO", "Lesotho", 426, 266 },
                    { "LT", "LITHUANIA", "LTU", "Lithuania", 440, 370 },
                    { "LU", "LUXEMBOURG", "LUX", "Luxembourg", 442, 352 },
                    { "LV", "LATVIA", "LVA", "Latvia", 428, 371 },
                    { "LY", "LIBYAN ARAB JAMAHIRIYA", "LBY", "Libyan Arab Jamahiriya", 434, 218 },
                    { "MA", "MOROCCO", "MAR", "Morocco", 504, 212 },
                    { "MC", "MONACO", "MCO", "Monaco", 492, 377 },
                    { "MD", "MOLDOVA, REPUBLIC OF", "MDA", "Moldova, Republic of", 498, 373 },
                    { "MG", "MADAGASCAR", "MDG", "Madagascar", 450, 261 },
                    { "MH", "MARSHALL ISLANDS", "MHL", "Marshall Islands", 584, 692 },
                    { "MK", "MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF", "MKD", "Macedonia, the Former Yugoslav Republic of", 807, 389 },
                    { "ML", "MALI", "MLI", "Mali", 466, 223 },
                    { "MM", "MYANMAR", "MMR", "Myanmar", 104, 95 },
                    { "MN", "MONGOLIA", "MNG", "Mongolia", 496, 976 },
                    { "MO", "MACAO", "MAC", "Macao", 446, 853 },
                    { "MP", "NORTHERN MARIANA ISLANDS", "MNP", "Northern Mariana Islands", 580, 1670 },
                    { "MQ", "MARTINIQUE", "MTQ", "Martinique", 474, 596 },
                    { "MR", "MAURITANIA", "MRT", "Mauritania", 478, 222 },
                    { "MS", "MONTSERRAT", "MSR", "Montserrat", 500, 1664 },
                    { "MT", "MALTA", "MLT", "Malta", 470, 356 },
                    { "MU", "MAURITIUS", "MUS", "Mauritius", 480, 230 },
                    { "MV", "MALDIVES", "MDV", "Maldives", 462, 960 },
                    { "MW", "MALAWI", "MWI", "Malawi", 454, 265 },
                    { "MX", "MEXICO", "MEX", "Mexico", 484, 52 },
                    { "MY", "MALAYSIA", "MYS", "Malaysia", 458, 60 },
                    { "MZ", "MOZAMBIQUE", "MOZ", "Mozambique", 508, 258 },
                    { "NA", "NAMIBIA", "NAM", "Namibia", 516, 264 },
                    { "NC", "NEW CALEDONIA", "NCL", "New Caledonia", 540, 687 },
                    { "NE", "NIGER", "NER", "Niger", 562, 227 },
                    { "NF", "NORFOLK ISLAND", "NFK", "Norfolk Island", 574, 672 },
                    { "NG", "NIGERIA", "NGA", "Nigeria", 566, 234 },
                    { "NI", "NICARAGUA", "NIC", "Nicaragua", 558, 505 },
                    { "NL", "NETHERLANDS", "NLD", "Netherlands", 528, 31 },
                    { "NO", "NORWAY", "NOR", "Norway", 578, 47 },
                    { "NP", "NEPAL", "NPL", "Nepal", 524, 977 },
                    { "NR", "NAURU", "NRU", "Nauru", 520, 674 },
                    { "NU", "NIUE", "NIU", "Niue", 570, 683 },
                    { "NZ", "NEW ZEALAND", "NZL", "New Zealand", 554, 64 },
                    { "OM", "OMAN", "OMN", "Oman", 512, 968 },
                    { "PA", "PANAMA", "PAN", "Panama", 591, 507 },
                    { "PE", "PERU", "PER", "Peru", 604, 51 },
                    { "PF", "FRENCH POLYNESIA", "PYF", "French Polynesia", 258, 689 },
                    { "PG", "PAPUA NEW GUINEA", "PNG", "Papua New Guinea", 598, 675 },
                    { "PH", "PHILIPPINES", "PHL", "Philippines", 608, 63 },
                    { "PK", "PAKISTAN", "PAK", "Pakistan", 586, 92 },
                    { "PL", "POLAND", "POL", "Poland", 616, 48 },
                    { "PM", "SAINT PIERRE AND MIQUELON", "SPM", "Saint Pierre and Miquelon", 666, 508 },
                    { "PN", "PITCAIRN", "PCN", "Pitcairn", 612, 0 },
                    { "PR", "PUERTO RICO", "PRI", "Puerto Rico", 630, 1787 },
                    { "PS", "PALESTINIAN TERRITORY, OCCUPIED", "", "Palestinian Territory, Occupied", null, 970 },
                    { "PT", "PORTUGAL", "PRT", "Portugal", 620, 351 },
                    { "PW", "PALAU", "PLW", "Palau", 585, 680 },
                    { "PY", "PARAGUAY", "PRY", "Paraguay", 600, 595 },
                    { "QA", "QATAR", "QAT", "Qatar", 634, 974 },
                    { "RE", "REUNION", "REU", "Reunion", 638, 262 },
                    { "RO", "ROMANIA", "ROM", "Romania", 642, 40 },
                    { "RU", "RUSSIAN FEDERATION", "RUS", "Russian Federation", 643, 70 },
                    { "RW", "RWANDA", "RWA", "Rwanda", 646, 250 },
                    { "SA", "SAUDI ARABIA", "SAU", "Saudi Arabia", 682, 966 },
                    { "SB", "SOLOMON ISLANDS", "SLB", "Solomon Islands", 90, 677 },
                    { "SC", "SEYCHELLES", "SYC", "Seychelles", 690, 248 },
                    { "SD", "SUDAN", "SDN", "Sudan", 736, 249 },
                    { "SE", "SWEDEN", "SWE", "Sweden", 752, 46 },
                    { "SG", "SINGAPORE", "SGP", "Singapore", 702, 65 },
                    { "SH", "SAINT HELENA", "SHN", "Saint Helena", 654, 290 },
                    { "SI", "SLOVENIA", "SVN", "Slovenia", 705, 386 },
                    { "SJ", "SVALBARD AND JAN MAYEN", "SJM", "Svalbard and Jan Mayen", 744, 47 },
                    { "SK", "SLOVAKIA", "SVK", "Slovakia", 703, 421 },
                    { "SL", "SIERRA LEONE", "SLE", "Sierra Leone", 694, 232 },
                    { "SM", "SAN MARINO", "SMR", "San Marino", 674, 378 },
                    { "SN", "SENEGAL", "SEN", "Senegal", 686, 221 },
                    { "SO", "SOMALIA", "SOM", "Somalia", 706, 252 },
                    { "SR", "SURINAME", "SUR", "Suriname", 740, 597 },
                    { "ST", "SAO TOME AND PRINCIPE", "STP", "Sao Tome and Principe", 678, 239 },
                    { "SV", "EL SALVADOR", "SLV", "El Salvador", 222, 503 },
                    { "SY", "SYRIAN ARAB REPUBLIC", "SYR", "Syrian Arab Republic", 760, 963 },
                    { "SZ", "SWAZILAND", "SWZ", "Swaziland", 748, 268 },
                    { "TC", "TURKS AND CAICOS ISLANDS", "TCA", "Turks and Caicos Islands", 796, 1649 },
                    { "TD", "CHAD", "TCD", "Chad", 148, 235 },
                    { "TF", "FRENCH SOUTHERN TERRITORIES", "", "French Southern Territories", null, 0 },
                    { "TG", "TOGO", "TGO", "Togo", 768, 228 },
                    { "TH", "THAILAND", "THA", "Thailand", 764, 66 },
                    { "TJ", "TAJIKISTAN", "TJK", "Tajikistan", 762, 992 },
                    { "TK", "TOKELAU", "TKL", "Tokelau", 772, 690 },
                    { "TL", "TIMOR-LESTE", "", "Timor-Leste", null, 670 },
                    { "TM", "TURKMENISTAN", "TKM", "Turkmenistan", 795, 7370 },
                    { "TN", "TUNISIA", "TUN", "Tunisia", 788, 216 },
                    { "TO", "TONGA", "TON", "Tonga", 776, 676 },
                    { "TR", "TURKEY", "TUR", "Turkey", 792, 90 },
                    { "TT", "TRINIDAD AND TOBAGO", "TTO", "Trinidad and Tobago", 780, 1868 },
                    { "TV", "TUVALU", "TUV", "Tuvalu", 798, 688 },
                    { "TW", "TAIWAN, PROVINCE OF CHINA", "TWN", "Taiwan, Province of China", 158, 886 },
                    { "TZ", "TANZANIA, UNITED REPUBLIC OF", "TZA", "Tanzania, United Republic of", 834, 255 },
                    { "UA", "UKRAINE", "UKR", "Ukraine", 804, 380 },
                    { "UG", "UGANDA", "UGA", "Uganda", 800, 256 },
                    { "UM", "UNITED STATES MINOR OUTLYING ISLANDS", "", "United States Minor Outlying Islands", null, 1 },
                    { "US", "UNITED STATES", "USA", "United States", 840, 1 },
                    { "UY", "URUGUAY", "URY", "Uruguay", 858, 598 },
                    { "UZ", "UZBEKISTAN", "UZB", "Uzbekistan", 860, 998 },
                    { "VA", "HOLY SEE (VATICAN CITY STATE)", "VAT", "Holy See (Vatican City State)", 336, 39 },
                    { "VC", "SAINT VINCENT AND THE GRENADINES", "VCT", "Saint Vincent and the Grenadines", 670, 1784 },
                    { "VE", "VENEZUELA", "VEN", "Venezuela", 862, 58 },
                    { "VG", "VIRGIN ISLANDS, BRITISH", "VGB", "Virgin Islands, British", 92, 1284 },
                    { "VI", "VIRGIN ISLANDS, U.S.", "VIR", "Virgin Islands, U.s.", 850, 1340 },
                    { "VN", "VIET NAM", "VNM", "Viet Nam", 704, 84 },
                    { "VU", "VANUATU", "VUT", "Vanuatu", 548, 678 },
                    { "WF", "WALLIS AND FUTUNA", "WLF", "Wallis and Futuna", 876, 681 },
                    { "WS", "SAMOA", "WSM", "Samoa", 882, 684 },
                    { "YE", "YEMEN", "YEM", "Yemen", 887, 967 },
                    { "YT", "MAYOTTE", "", "Mayotte", null, 269 },
                    { "ZA", "SOUTH AFRICA", "ZAF", "South Africa", 710, 27 },
                    { "ZM", "ZAMBIA", "ZMB", "Zambia", 894, 260 },
                    { "ZW", "ZIMBABWE", "ZWE", "Zimbabwe", 716, 263 }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Code3", "Code2", "Name", "NativeName" },
                values: new object[,]
                {
                    { "aar", "aa", "Afar", "Afaraf" },
                    { "abk", "ab", "Abkhaz", "аҧсуа бызшәа, аҧсшәа" },
                    { "afr", "af", "Afrikaans", "Afrikaans" },
                    { "aka", "ak", "Akan", "Akan" },
                    { "amh", "am", "Amharic", "አማርኛ" },
                    { "ara", "ar", "Arabic", "العربية" },
                    { "arg", "an", "Aragonese", "aragonés" },
                    { "asm", "as", "Assamese", "অসমীয়া" },
                    { "ava", "av", "Avaric", "авар мацӀ, магӀарул мацӀ" },
                    { "ave", "ae", "Avestan", "avesta" },
                    { "aym", "ay", "Aymara", "aymar aru" },
                    { "azb", "az", "South Azerbaijani", "تورکجه‎" },
                    { "aze", "az", "Azerbaijani", "azərbaycan dili" },
                    { "bak", "ba", "Bashkir", "башҡорт теле" },
                    { "bam", "bm", "Bambara", "bamanankan" },
                    { "bel", "be", "Belarusian", "беларуская мова" },
                    { "ben", "bn", "Bengali; Bangla", "বাংলা" },
                    { "bih", "bh", "Bihari", "भोजपुरी" },
                    { "bis", "bi", "Bislama", "Bislama" },
                    { "bod", "bo", "Tibetan Standard, Tibetan, Central", "བོད་ཡིག" },
                    { "bos", "bs", "Bosnian", "bosanski jezik" },
                    { "bre", "br", "Breton", "brezhoneg" },
                    { "bul", "bg", "Bulgarian", "български език" },
                    { "cat", "ca", "Catalan; Valencian", "català, valencià" },
                    { "ces", "cs", "Czech", "čeština, český jazyk" },
                    { "cha", "ch", "Chamorro", "Chamoru" },
                    { "che", "ce", "Chechen", "нохчийн мотт" },
                    { "chu", "cu", "Old Church Slavonic, Church Slavonic, Old Bulgarian", "ѩзыкъ словѣньскъ" },
                    { "chv", "cv", "Chuvash", "чӑваш чӗлхи" },
                    { "cor", "kw", "Cornish", "Kernewek" },
                    { "cos", "co", "Corsican", "corsu, lingua corsa" },
                    { "cre", "cr", "Cree", "ᓀᐦᐃᔭᐍᐏᐣ" },
                    { "cym", "cy", "Welsh", "Cymraeg" },
                    { "dan", "da", "Danish", "dansk" },
                    { "deu", "de", "German", "Deutsch" },
                    { "div", "dv", "Divehi; Dhivehi; Maldivian;", "ދިވެހި" },
                    { "dzo", "dz", "Dzongkha", "རྫོང་ཁ" },
                    { "ell", "el", "Greek, Modern", "ελληνικά" },
                    { "eng", "en", "English", "English" },
                    { "epo", "eo", "Esperanto", "Esperanto" },
                    { "est", "et", "Estonian", "eesti, eesti keel" },
                    { "eus", "eu", "Basque", "euskara, euskera" },
                    { "ewe", "ee", "Ewe", "Eʋegbe" },
                    { "fao", "fo", "Faroese", "føroyskt" },
                    { "fas", "fa", "Persian (Farsi)", "فارسی" },
                    { "fij", "fj", "Fijian", "vosa Vakaviti" },
                    { "fin", "fi", "Finnish", "suomi, suomen kieli" },
                    { "fra", "fr", "French", "français, langue française" },
                    { "fry", "fy", "Western Frisian", "Frysk" },
                    { "ful", "ff", "Fula; Fulah; Pulaar; Pular", "Fulfulde, Pulaar, Pular" },
                    { "gla", "gd", "Scottish Gaelic; Gaelic", "Gàidhlig" },
                    { "gle", "ga", "Irish", "Gaeilge" },
                    { "glg", "gl", "Galician", "galego" },
                    { "glv", "gv", "Manx", "Gaelg, Gailck" },
                    { "grn", "gn", "Guaraní", "Avañe'ẽ" },
                    { "guj", "gu", "Gujarati", "ગુજરાતી" },
                    { "hat", "ht", "Haitian; Haitian Creole", "Kreyòl ayisyen" },
                    { "hau", "ha", "Hausa", "Hausa, هَوُسَ" },
                    { "heb", "he", "Hebrew (modern)", "עברית" },
                    { "her", "hz", "Herero", "Otjiherero" },
                    { "hin", "hi", "Hindi", "हिन्दी, हिंदी" },
                    { "hmo", "ho", "Hiri Motu", "Hiri Motu" },
                    { "hrv", "hr", "Croatian", "hrvatski jezik" },
                    { "hun", "hu", "Hungarian", "magyar" },
                    { "hye", "hy", "Armenian", "Հայերեն" },
                    { "ibo", "ig", "Igbo", "Asụsụ Igbo" },
                    { "ido", "io", "Ido", "Ido" },
                    { "iii", "ii", "Nuosu", "ꆈꌠ꒿ Nuosuhxop" },
                    { "iku", "iu", "Inuktitut", "ᐃᓄᒃᑎᑐᑦ" },
                    { "ile", "ie", "Interlingue", "Originally called Occidental; then Interlingue after WWII" },
                    { "ina", "ia", "Interlingua", "Interlingua" },
                    { "ind", "id", "Indonesian", "Bahasa Indonesia" },
                    { "ipk", "ik", "Inupiaq", "Iñupiaq, Iñupiatun" },
                    { "isl", "is", "Icelandic", "Íslenska" },
                    { "ita", "it", "Italian", "italiano" },
                    { "jav", "jv", "Javanese", "basa Jawa" },
                    { "jpn", "ja", "Japanese", "日本語 (にほんご)" },
                    { "kal", "kl", "Kalaallisut, Greenlandic", "kalaallisut, kalaallit oqaasii" },
                    { "kan", "kn", "Kannada", "ಕನ್ನಡ" },
                    { "kas", "ks", "Kashmiri", "कश्मीरी, كشميري‎" },
                    { "kat", "ka", "Georgian", "ქართული" },
                    { "kau", "kr", "Kanuri", "Kanuri" },
                    { "kaz", "kk", "Kazakh", "қазақ тілі" },
                    { "khm", "km", "Khmer", "ខ្មែរ, ខេមរភាសា, ភាសាខ្មែរ" },
                    { "kik", "ki", "Kikuyu, Gikuyu", "Gĩkũyũ" },
                    { "kin", "rw", "Kinyarwanda", "Ikinyarwanda" },
                    { "kir", "ky", "Kyrgyz", "Кыргызча, Кыргыз тили" },
                    { "kom", "kv", "Komi", "коми кыв" },
                    { "kon", "kg", "Kongo", "KiKongo" },
                    { "kor", "ko", "Korean", "한국어 (韓國語), 조선어 (朝鮮語)" },
                    { "kua", "kj", "Kwanyama, Kuanyama", "Kuanyama" },
                    { "kur", "ku", "Kurdish", "Kurdî, كوردی‎" },
                    { "lao", "lo", "Lao", "ພາສາລາວ" },
                    { "lat", "la", "Latin", "latine, lingua latina" },
                    { "lav", "lv", "Latvian", "latviešu valoda" },
                    { "lim", "li", "Limburgish, Limburgan, Limburger", "Limburgs" },
                    { "lin", "ln", "Lingala", "Lingála" },
                    { "lit", "lt", "Lithuanian", "lietuvių kalba" },
                    { "ltz", "lb", "Luxembourgish, Letzeburgesch", "Lëtzebuergesch" },
                    { "lub", "lu", "Luba-Katanga", "Tshiluba" },
                    { "lug", "lg", "Ganda", "Luganda" },
                    { "mah", "mh", "Marshallese", "Kajin M̧ajeļ" },
                    { "mal", "ml", "Malayalam", "മലയാളം" },
                    { "mar", "mr", "Marathi (Marāṭhī)", "मराठी" },
                    { "mkd", "mk", "Macedonian", "македонски јазик" },
                    { "mlg", "mg", "Malagasy", "fiteny malagasy" },
                    { "mlt", "mt", "Maltese", "Malti" },
                    { "mon", "mn", "Mongolian", "монгол" },
                    { "mri", "mi", "Māori", "te reo Māori" },
                    { "msa", "ms", "Malay", "bahasa Melayu, بهاس ملايو‎" },
                    { "mya", "my", "Burmese", "ဗမာစာ" },
                    { "nau", "na", "Nauru", "Ekakairũ Naoero" },
                    { "nav", "nv", "Navajo, Navaho", "Diné bizaad, Dinékʼehǰí" },
                    { "nbl", "nr", "South Ndebele", "isiNdebele" },
                    { "nde", "nd", "North Ndebele", "isiNdebele" },
                    { "ndo", "ng", "Ndonga", "Owambo" },
                    { "nep", "ne", "Nepali", "नेपाली" },
                    { "nld", "nl", "Dutch", "Nederlands, Vlaams" },
                    { "nno", "nn", "Norwegian Nynorsk", "Norsk nynorsk" },
                    { "nob", "nb", "Norwegian Bokmål", "Norsk bokmål" },
                    { "nor", "no", "Norwegian", "Norsk" },
                    { "nya", "ny", "Chichewa; Chewa; Nyanja", "chiCheŵa, chinyanja" },
                    { "oci", "oc", "Occitan", "occitan, lenga d'òc" },
                    { "oji", "oj", "Ojibwe, Ojibwa", "ᐊᓂᔑᓈᐯᒧᐎᓐ" },
                    { "ori", "or", "Oriya", "ଓଡ଼ିଆ" },
                    { "orm", "om", "Oromo", "Afaan Oromoo" },
                    { "oss", "os", "Ossetian, Ossetic", "ирон æвзаг" },
                    { "pan", "pa", "Panjabi, Punjabi", "ਪੰਜਾਬੀ, پنجابی‎" },
                    { "pli", "pi", "Pāli", "पाऴि" },
                    { "pol", "pl", "Polish", "język polski, polszczyzna" },
                    { "por", "pt", "Portuguese", "português" },
                    { "pus", "ps", "Pashto, Pushto", "پښتو" },
                    { "que", "qu", "Quechua", "Runa Simi, Kichwa" },
                    { "roh", "rm", "Romansh", "rumantsch grischun" },
                    { "ron", "ro", "Romanian", "limba română" },
                    { "run", "rn", "Kirundi", "Ikirundi" },
                    { "rus", "ru", "Russian", "русский язык" },
                    { "sag", "sg", "Sango", "yângâ tî sängö" },
                    { "san", "sa", "Sanskrit (Saṁskṛta)", "संस्कृतम्" },
                    { "sin", "si", "Sinhala, Sinhalese", "සිංහල" },
                    { "slk", "sk", "Slovak", "slovenčina, slovenský jazyk" },
                    { "slv", "sl", "Slovene", "slovenski jezik, slovenščina" },
                    { "sme", "se", "Northern Sami", "Davvisámegiella" },
                    { "smo", "sm", "Samoan", "gagana fa'a Samoa" },
                    { "sna", "sn", "Shona", "chiShona" },
                    { "snd", "sd", "Sindhi", "सिन्धी, سنڌي، سندھی‎" },
                    { "som", "so", "Somali", "Soomaaliga, af Soomaali" },
                    { "sot", "st", "Southern Sotho", "Sesotho" },
                    { "spa", "es", "Spanish", "español" },
                    { "sqi", "sq", "Albanian", "gjuha shqipe" },
                    { "srd", "sc", "Sardinian", "sardu" },
                    { "srp", "sr", "Serbian", "српски језик" },
                    { "ssw", "ss", "Swati", "SiSwati" },
                    { "sun", "su", "Sundanese", "Basa Sunda" },
                    { "swa", "sw", "Swahili", "Kiswahili" },
                    { "swe", "sv", "Swedish", "Svenska" },
                    { "tah", "ty", "Tahitian", "Reo Tahiti" },
                    { "tam", "ta", "Tamil", "தமிழ்" },
                    { "tat", "tt", "Tatar", "татар теле, tatar tele" },
                    { "tel", "te", "Telugu", "తెలుగు" },
                    { "tgk", "tg", "Tajik", "тоҷикӣ, toğikī, تاجیکی‎" },
                    { "tgl", "tl", "Tagalog", "Wikang Tagalog, ᜏᜒᜃᜅ᜔ ᜆᜄᜎᜓᜄ᜔" },
                    { "tha", "th", "Thai", "ไทย" },
                    { "tir", "ti", "Tigrinya", "ትግርኛ" },
                    { "ton", "to", "Tonga (Tonga Islands)", "faka Tonga" },
                    { "tsn", "tn", "Tswana", "Setswana" },
                    { "tso", "ts", "Tsonga", "Xitsonga" },
                    { "tuk", "tk", "Turkmen", "Türkmen, Түркмен" },
                    { "tur", "tr", "Turkish", "Türkçe" },
                    { "twi", "tw", "Twi", "Twi" },
                    { "uig", "ug", "Uyghur, Uighur", "Uyƣurqə, ئۇيغۇرچە‎" },
                    { "ukr", "uk", "Ukrainian", "українська мова" },
                    { "urd", "ur", "Urdu", "اردو" },
                    { "uzb", "uz", "Uzbek", "O‘zbek, Ўзбек, أۇزبېك‎" },
                    { "ven", "ve", "Venda", "Tshivenḓa" },
                    { "vie", "vi", "Vietnamese", "Tiếng Việt" },
                    { "vol", "vo", "Volapük", "Volapük" },
                    { "wln", "wa", "Walloon", "walon" },
                    { "wol", "wo", "Wolof", "Wollof" },
                    { "xho", "xh", "Xhosa", "isiXhosa" },
                    { "yid", "yi", "Yiddish", "ייִדיש" },
                    { "yor", "yo", "Yoruba", "Yorùbá" },
                    { "zha", "za", "Zhuang, Chuang", "Saɯ cueŋƅ, Saw cuengh" },
                    { "zho", "zh", "Chinese", "中文 (Zhōngwén), 汉语, 漢語" },
                    { "zul", "zu", "Zulu", "isiZulu" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Azure" },
                    { 3, "Sql Server" },
                    { 4, "Angular" },
                    { 5, "Entity Framework" },
                    { 6, "TypeScript" },
                    { 7, "CI/CD" },
                    { 8, "oAuth2" },
                    { 9, "Visual Studio" },
                    { 10, "Identity Server" },
                    { 11, "Postman" },
                    { 12, "SignalR" },
                    { 13, "Material Design" },
                    { 14, "Bootstrap" },
                    { 15, "Figma" },
                    { 16, "gRPC" },
                    { 17, "Blazor" },
                    { 18, "Geneva" },
                    { 19, "Data Explorer" },
                    { 20, "Synapse" },
                    { 21, "Function Apps" },
                    { 22, "AppInsights" },
                    { 23, "Kusto" },
                    { 24, "Bicep" },
                    { 25, "Api Integrations" },
                    { 26, "Orchard" },
                    { 27, "Objective-C" },
                    { 29, "WCF" },
                    { 30, "IIS" },
                    { 31, ".NET Framework" },
                    { 32, "WPF" },
                    { 33, "Classic ASP" },
                    { 34, "ASP.NET" },
                    { 35, "Big Data" },
                    { 36, "Html/CSS" },
                    { 37, "Artificial Intelligence (AI)" },
                    { 38, ".Net Core" },
                    { 39, "Stripe" },
                    { 40, "WebHooks" },
                    { 41, "Microsoft Teams" },
                    { 42, "Jira" },
                    { 43, "jQuery" },
                    { 44, "JavaScript" },
                    { 45, "Powershell" },
                    { 46, "Python" },
                    { 47, "XAML" },
                    { 48, "Java" },
                    { 49, "C++" },
                    { 50, "PHP" },
                    { 51, "Swift" },
                    { 52, "Ruby" },
                    { 53, "C" },
                    { 54, "Kotlin" },
                    { 55, "R" },
                    { 56, "Go" },
                    { 57, "Scala" },
                    { 58, "Perl" },
                    { 59, "Rust" },
                    { 60, "Dart" },
                    { 61, "Elixir" },
                    { 62, "Haskell" },
                    { 63, "MySQL" },
                    { 64, "PostgreSQL" },
                    { 65, "MongoDB" },
                    { 66, "Oracle Database" },
                    { 67, "Spring" },
                    { 68, "Django" },
                    { 69, "Ruby on Rails" },
                    { 70, "React" },
                    { 71, "Vue.js" },
                    { 72, "Laravel" },
                    { 73, "Express.js" },
                    { 74, "Flask" },
                    { 75, "Symfony" },
                    { 76, "Meteor" },
                    { 77, "Svelte" },
                    { 78, "Next.js" },
                    { 79, "Gatsby" },
                    { 80, "Play Framework" },
                    { 81, "CodeIgniter" },
                    { 82, "CakePHP" },
                    { 83, "Phoenix" },
                    { 84, "NestJS" },
                    { 85, "Jenkins" },
                    { 86, "Docker" },
                    { 87, "Kubernetes" },
                    { 88, "Ansible" },
                    { 89, "Terraform" },
                    { 90, "GitLab" },
                    { 91, "Prometheus" },
                    { 92, "Nagios" },
                    { 93, "Puppet" },
                    { 94, "Chef" },
                    { 95, "Azure Devops" },
                    { 96, "Amazon Web Services (AWS)" },
                    { 97, "Google Cloud Platform" },
                    { 98, "Oracle Cloud" },
                    { 99, "IBM Cloud" },
                    { 100, "Google APIs" },
                    { 101, "Twitter API" },
                    { 102, "Facebook API" },
                    { 103, "Amazon AWS API" },
                    { 104, "Twilio API" },
                    { 105, "Spotify API" }
                });

            migrationBuilder.InsertData(
                table: "StateProvince",
                columns: new[] { "Id", "Abbrev", "Code", "Iso2", "Name" },
                values: new object[,]
                {
                    { 1, "Ala.", "AL", "US", "Alabama" },
                    { 2, "Alaska", "AK", "US", "Alaska" },
                    { 3, "Ariz.", "AZ", "US", "Arizona" },
                    { 4, "Ark.", "AR", "US", "Arkansas" },
                    { 5, "Calif.", "CA", "US", "California" },
                    { 6, "Colo.", "CO", "US", "Colorado" },
                    { 7, "Conn.", "CT", "US", "Connecticut" },
                    { 8, "Del.", "DE", "US", "Delaware" },
                    { 9, "D.C.", "DC", "US", "District of Columbia" },
                    { 10, "Fla.", "FL", "US", "Florida" },
                    { 11, "Ga.", "GA", "US", "Georgia" },
                    { 12, "Hawaii", "HI", "US", "Hawaii" },
                    { 13, "Idaho", "ID", "US", "Idaho" },
                    { 14, "Ill.", "IL", "US", "Illinois" },
                    { 15, "Ind.", "IN", "US", "Indiana" },
                    { 16, "Iowa", "IA", "US", "Iowa" },
                    { 17, "Kans.", "KS", "US", "Kansas" },
                    { 18, "Ky.", "KY", "US", "Kentucky" },
                    { 19, "La.", "LA", "US", "Louisiana" },
                    { 20, "Maine", "ME", "US", "Maine" },
                    { 21, "Md.", "MD", "US", "Maryland" },
                    { 22, "Mass.", "MA", "US", "Massachusetts" },
                    { 23, "Mich.", "MI", "US", "Michigan" },
                    { 24, "Minn.", "MN", "US", "Minnesota" },
                    { 25, "Miss.", "MS", "US", "Mississippi" },
                    { 26, "Mo.", "MO", "US", "Missouri" },
                    { 27, "Mont.", "MT", "US", "Montana" },
                    { 28, "Nebr.", "NE", "US", "Nebraska" },
                    { 29, "Nev.", "NV", "US", "Nevada" },
                    { 30, "N.H.", "NH", "US", "New Hampshire" },
                    { 31, "N.J.", "NJ", "US", "New Jersey" },
                    { 32, "N.M.", "NM", "US", "New Mexico" },
                    { 33, "N.Y.", "NY", "US", "New York" },
                    { 34, "N.C.", "NC", "US", "North Carolina" },
                    { 35, "N.D.", "ND", "US", "North Dakota" },
                    { 36, "Ohio", "OH", "US", "Ohio" },
                    { 37, "Okla.", "OK", "US", "Oklahoma" },
                    { 38, "Ore.", "OR", "US", "Oregon" },
                    { 39, "Pa.", "PA", "US", "Pennsylvania" },
                    { 40, "R.I.", "RI", "US", "Rhode Island" },
                    { 41, "S.C.", "SC", "US", "South Carolina" },
                    { 42, "S.D.", "SD", "US", "South Dakota" },
                    { 43, "Tenn.", "TN", "US", "Tennessee" },
                    { 44, "Tex.", "TX", "US", "Texas" },
                    { 45, "Utah", "UT", "US", "Utah" },
                    { 46, "Vt.", "VT", "US", "Vermont" },
                    { 47, "Va.", "VA", "US", "Virginia" },
                    { 48, "Wash.", "WA", "US", "Washington" },
                    { 49, "W.Va.", "WV", "US", "West Virginia" },
                    { 50, "Wis.", "WI", "US", "Wisconsin" },
                    { 51, "Wyo.", "WY", "US", "Wyoming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AQ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "AZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BB");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BJ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "BZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CX");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "CZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DJ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "DZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "EC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "EE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "EG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "EH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ER");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ET");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FJ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GP");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GQ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "GY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "HU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IQ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "JM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "JO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "JP");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KP");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "KZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LB");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "LY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ML");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MP");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MQ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MX");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "MZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NP");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "NZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "OM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "PY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "QA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "RE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "RO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "RU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "RW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SB");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SJ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ST");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "SZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TD");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TH");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TJ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TK");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TL");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TO");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TR");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TV");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TW");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "TZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "UA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "UG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "UM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "UY");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "UZ");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VC");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VG");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VI");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VN");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "VU");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "WF");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "WS");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "YE");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "YT");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ZA");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ZM");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "ZW");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "aar");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "abk");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "afr");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "aka");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "amh");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ara");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "arg");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "asm");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ava");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ave");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "aym");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "azb");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "aze");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bak");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bam");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bel");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ben");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bih");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bis");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bod");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bos");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bre");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "bul");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cat");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ces");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cha");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "che");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "chu");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "chv");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cor");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cos");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cre");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "cym");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "dan");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "deu");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "div");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "dzo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ell");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "eng");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "epo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "est");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "eus");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ewe");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fao");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fas");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fij");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fin");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fra");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "fry");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ful");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "gla");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "gle");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "glg");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "glv");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "grn");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "guj");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hat");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hau");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "heb");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "her");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hin");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hmo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hrv");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hun");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "hye");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ibo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ido");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "iii");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "iku");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ile");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ina");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ind");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ipk");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "isl");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ita");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "jav");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "jpn");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kal");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kan");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kas");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kat");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kau");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kaz");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "khm");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kik");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kin");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kir");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kom");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kon");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kor");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kua");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "kur");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lao");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lat");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lav");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lim");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lin");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lit");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ltz");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lub");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "lug");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mah");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mal");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mar");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mkd");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mlg");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mlt");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mon");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mri");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "msa");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "mya");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nau");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nav");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nbl");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nde");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ndo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nep");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nld");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nno");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nob");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nor");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "nya");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "oci");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "oji");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ori");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "orm");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "oss");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "pan");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "pli");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "pol");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "por");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "pus");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "que");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "roh");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ron");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "run");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "rus");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sag");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "san");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sin");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "slk");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "slv");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sme");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "smo");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sna");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "snd");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "som");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sot");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "spa");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sqi");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "srd");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "srp");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ssw");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "sun");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "swa");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "swe");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tah");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tam");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tat");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tel");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tgk");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tgl");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tha");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tir");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ton");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tsn");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tso");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tuk");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "tur");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "twi");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "uig");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ukr");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "urd");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "uzb");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "ven");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "vie");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "vol");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "wln");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "wol");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "xho");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "yid");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "yor");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "zha");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "zho");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Code3",
                keyValue: "zul");

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StateProvince",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Iso2",
                keyValue: "US");
        }
    }
}
