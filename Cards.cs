using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace BCCC
{
	public class newStriker
	{
		public string Academy;
		public string Name;
		public string Explanation;
		/// <summary>
		/// 0 : 딜
		/// 1 : 탱<br/>
		/// 2 : 힐
		/// 3 : 서폿
		/// </summary>
		public int Position;
		/// <summary>
		/// 스페셜카드는 100
		/// </summary>
		public int HP;
		/// <summary>
		/// 스페셜카드는 4
		/// </summary>
		public int Reach;
		public int Damage;
		public int Cost;
		public Texture2D img;
		public float width;
		public float height;
		public Vector2 pos;
		public float scale;
		public float angle;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Academy">학원</param>
		/// <param name="Name">이름</param>
		/// <param name="Explanation">EX 설명</param>
		/// <param name="Position">0 : 딜<br/>1 : 탱<br/>2 : 힐<br/>3 : 서폿<br/></param>
		/// <param name="HP">체력</param>
		/// <param name="Reach">사거리</param>
		/// <param name="Damage">데미지</param>
		/// <param name="Cost">코스트</param>
		public newStriker(string Academy, string Name, string Explanation, int Position, int HP, int Reach, int Damage, int Cost)
		{
			this.Academy = Academy;
			this.Name = Name;
			this.Explanation = Explanation;
			this.Position = Position;
			this.HP = HP;
			this.Reach = Reach;
			this.Damage = Damage;
			this.Cost = Cost;
		}
	}

	public class newSpecial
	{
		public string Academy;
		public string Name;
		public string Explanation;
		/// <summary>
		/// 0 : 딜
		/// 1 : 탱<br/>
		/// 2 : 힐
		/// 3 : 서폿
		/// </summary>
		public int Position;
		public int Cost;
		public Texture2D img;
		public float width;
		public float height;
		public Vector2 pos;
		public float scale;
		public float angle;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Academy">학원</param>
		/// <param name="Name">이름</param>
		/// <param name="Explanation">EX 설명</param>
		/// <param name="Position">0 : 딜<br/>1 : 탱<br/>2 : 힐<br/>3 : 서폿<br/></param>
		/// <param name="Cost">코스트</param>
		public newSpecial(string Academy, string Name, string Explanation, int Position, int Cost)
		{
			this.Academy = Academy;
			this.Name = Name;
			this.Explanation = Explanation;
			this.Position = Position;
			this.Cost = Cost;
		}
	}

	public class newGoods
	{
		public string Name;
		public string Explanation;
		public int Slot;
		public int Action;
		public Texture2D img;
		public float width;
		public float height;
		public Vector2 pos;
		public float scale;
		public float angle;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Name">이름</param>
		/// <param name="Explanation">설명</param>
		/// <param name="Slot">슬롯</param>
		/// <param name="Action">엑션</param>
		public newGoods(string Name, string Explanation, int Slot, int Action)
		{
			this.Name = Name;
			this.Explanation = Explanation;
			this.Slot = Slot;
			this.Action = Action;
		}
	}

	public class Shoot
	{
		public string Name;
		public string Explanation;
		public int Action;
		public Shoot()
		{
			this.Name = "발포!";
			this.Explanation = "[ACTION]을 사용한 자신의 [STRIKER]의 사거리 범위의 상대 [STRIKER]에게 데미지 수치만큼 데미지를 준다.";
			this.Action = 1;
		}
	}

	internal class Cards
	{
		public class Abydos
		{
			// 아비도스
			public static newStriker Shiroko_Sunaookami;
			public static newStriker Shiroko_Sunaookami_special;
			public static newStriker Hoshino_Takanashi;
			public static newStriker Serika_Kuromi;
			public static newStriker Nonomi_Ijayomi;
			public static newSpecial Ayane_Okusora;

			public static void Init()
			{
				Shiroko_Sunaookami = new newStriker("아비도스", "스나오오카미 시로코", "상대 필드의 [STRIKER] 1장에게 2의 데미지를 준다.", 0, 5, 2, 2, 2);
				Shiroko_Sunaookami_special = Shiroko_Sunaookami; // 그냥 노말카드랑 똑같은데 이미지만 다른거임. 그냥 이쁨.
				Hoshino_Takanashi = new newStriker("아비도스", "타카나시 호시노", "상대 필드의 1, 2의 포지션에 있는 [STRIKER]에게 2 데미지를 주고 이 카드의 [HP]를 2 회복한다.", 1, 6, 1, 2, 4);
				Serika_Kuromi = new newStriker("아비도스", "쿠로미 세리카", "자신의 [TRASH]에 있는 [SHOT] 카드 1장을 패로 가져온다. 그 후 카드는 한번 더 [ACTION] 할 수 있다.", 0, 5, 3, 1, 2);
				Nonomi_Ijayomi = new newStriker("아비도스", "이자요미 노노미", "상대 필드의 1, 2, 3의 포지션에 있는 [STRIKER]에게 2 데미지를 준다.", 0, 5, 1, 3, 5);
				Ayane_Okusora = new newSpecial("아비도스", "오소쿠라 아야네", "자신의 [STRIKER] 카드를 3장 까지 선택하고 [HP]를 3씩 회복하고 1의 방어력을 얻는다. (방어력은 [HP]로 취급되며 데미지를 입을 시 사라진다.)", 2, 4);
			}
		}

		public class Gehenna
		{
			// 게헨나
			public static newStriker Aru_Rikuhachima;
			public static newStriker Aru_Rikuhachima_special;
			public static newStriker Mutsuki_Asagi;
			public static newStriker Kayoko_Onikata;
			public static newStriker Haruka_Igusa;
			public static newSpecial Juri_Ushimaki;
			public static newSpecial Fuuka_Aikiyo;
			// 선도부
			public static newStriker Hina_Sorasaki;
			public static newStriker Iori_Shiromi;
			public static newSpecial Chinatsu_Hinomiya;
			public static newSpecial Ako_Amau;

			public static void Init()
			{
				Aru_Rikuhachima = new newStriker("게헨나", "리쿠하치마 아루", "상대의 [STRIKER] 1장에게 4의 데미지를 준다.", 0, 4, 2, 3, 4);
				Aru_Rikuhachima_special = Aru_Rikuhachima;
				Mutsuki_Asagi = new newStriker("게헨나", "아사기 무츠키", "상대의 1, 2 포지션의 [STRIKER]에게 2 데미지를 준다. 데미지를 받은 [STRIKER]는 다음 턴 종료시 까지 [ACTION] 시 1 데미지를 받는다.", 0, 5, 2, 2, 4);
				Kayoko_Onikata = new newStriker("게헨나", "오니카타 카요코", "2턴 동안 자신의 [STRIKER] 전원의 데미지 수치는 1 증가한다. 그 후 상대 [STRIKER] 1장을 지정하고 다음 턴 종료 시까지 그 [STRIKER]는 [ACTION] 하지 못한다.", 3, 5, 2, 2, 6);
				Haruka_Igusa = new newStriker("게헨나", "이구사 하루카", "상대의 1, 2, 3 포지션의 [STRIKER]에게 1의 데미지를 준다. 그리고 이 카드는 2의 방어력은 얻는다. (방어력은 [HP]로  취급되며 데미지를 입을 시 사라진다.)", 1, 6, 1, 2, 4);
				Juri_Ushimaki = new newSpecial("게헨나", "우시마키 주리", "다음 턴 상대의 데미지 수치가 가장 높은 [STRIKER]는 [ACTION]을 하지 못한다. 그 후 상대의 모든 [STRIKER]는 [ACTION]시 1 데미지를 받는다.", 3, 3);
				Fuuka_Aikiyo = new newSpecial("게헨나", "아이키요 후우카", "자신의 [STRIKER] 전열의 [HP]를 2 회복한다. 그리고 자신의 [STRIKER]중 체력이 가장 높은 카드 1장은 2의 방어력을 얻는다.", 2, 5);
				Hina_Sorasaki = new newStriker("게헨나", "소라사키 히나", "상대 [STRIKER] 전원에게 4 데미지를 준다. 그 후 자신 필드의 [STRIKER]가 이 카드만 존재할 경우 이 카드는 한번 더 [ACTION]을 할 수 있다.", 0, 4, 2, 3, 7);
				Iori_Shiromi = new newStriker("게헨나", "시로미 이오리", "상대 1, 2, 3 포지션의 [STRIKER]에게 1 디미지를 준다. 만약 이 카드의 앞 포지션에 [STRIKER]에게 장비된 [GOODS] 카드가 존재하지 않을 경우 상대에게 주는 데미지는 2가 된다.", 0, 5, 2, 2, 3);
				Chinatsu_Hinomiya = new newSpecial("게헨나", "히노미야 치나츠", "자신 필드의 [STRIKER] 1장의 [HP]를 4 회복한다. 그 후 자신 필드의 [STRIKER] 2장을 고르고 그 2장의 포지션을 변경할 수 있다.", 2, 4);
				Ako_Amau = new newSpecial("게헨나", "아마우 아코", "자신의 [STRIKER] 2장을 고르고 그 [STRIKER]는 이번 턴 종료시 까지 [발포!] 사용시 주는 데미지를 1 증가시킨다.", 3, 3);
			}
		}

		public class Millennium
		{
			// 밀레니엄
			public static newStriker Aris_Tendo;
			public static newStriker Yuzu_Hanaoka;
			public static newStriker Midori_Saiba;
			public static newStriker Momoi_Saiba;
			public static newSpecial Utaha_Shiraishi;
			public static newSpecial Hibiki_Nekozuka;
			public static newSpecial Kotori_Toyumi;
			// 세미나
			public static newStriker Noa_Ushino;
			public static newStriker Yuuka_Hayase;
			public static newStriker Koyuki_Kurosaki;

			public static void Init()
			{
				Aris_Tendo = new newStriker("밀레니엄", "텐도 아리스", "이 카드에 장비한 [GOODS] 카드를 3장 까지 폐기한다. 폐기한 카드의 개수만큼 효과를 적용한다. 1장 이상 : 이 카드의 데미지 수치를 1 올린다. 2장 이상 : 상대 [STRIKER] 모두에게 2 데미지를 주고 데미지 수치를 2 올린다. 3장 이상 : 상대 [STRIKER] 모두에게 4 데미지를 주고 이 카드의 [HP]를 2 회복한다.", 0, 5, 4, 0, 6);
				Yuzu_Hanaoka = new newStriker("밀레니엄", "하나오카 유즈", "상대의 1, 2, 3의 포지션의 [STRIKER]에게 1의 데미지를 준다. 그 후 데미지 수치가 가장 높은 상대의 [STRIKER] 1장에게 추가로 2 데미지를 준다.", 0, 5, 2, 2, 4);
				Midori_Saiba = new newStriker("밀레니엄", "사이바 미도리", "상대 1, 2 포지션의 [STRIKER]에게 1의 데미지를 준다. [몸모이](오타아님)가 필드에 있다면 자신의 1, 2 포지션의 [STRIKER]의 [HP]를 2 회복한다.", 0, 4, 3, 2, 3);
				Momoi_Saiba = new newStriker("밀레니엄", "사이바 모모이", "상대의 1, 2 포지션 [STRIKER]에게 1의 데미지를 준다. [미도리]가 필드에 있다면 추가로 2의 데미지를 준다.", 0, 4, 2, 3, 3);
				Utaha_Shiraishi = new newSpecial("밀레니엄", "시라이시 우타하", "자신의 [STRIKER] 카드 1장의 데미지 수치를 턴 종료시까지 1 증가시킨다. 그 후 1의 방어력을 얻는다. 추가로 [TRASH]의 [천둥이] 1장을 패로 가져올 수 있다.", 0, 4);
				Hibiki_Nekozuka = new newSpecial("밀레니엄", "네코즈카 히키비", "상대의 1, 2, 3 포지션의 [STRIKER]에게 1의 데미지를 준다. 그 후 상대의 [HP] 수치가 가장 낮은 [STRIKER] 1장에게 2의 데미지를 준다.", 0, 4);
				Noa_Ushino = new newStriker("밀레니엄", "우시오 노아", "상대 [STRIKER] 1장에게 장비된 [GOODS] 카드 1장을 폐기한다. 그 후 그 [STRIKER]에게 1의 데미지를 준다.", 3, 5, 2, 2, 3);
				Yuuka_Hayase = new newStriker("밀레니엄", "하야세 유우카", "이 카드는 방어력을 2 얻는다.", 1, 6, 1, 2, 3);
				Koyuki_Kurosaki = new newStriker("밀레니엄", "쿠로사키 코유키", "패 1장을 트래쉬하고 상대 1, 2의 포지션의 [STRIKER]에게 2의 데미지를 준다. 트래쉬한 카드의 종류에 따라 효과를 적용한다. [GOODS] : 추가로 이 카드의 [HP]를 2 회복한다. [발포!] : 이 효과로 주는 데미지는 4가 된다. [그 외] : 이 효과로 데미지를 준 상대의 [STRIKER] 1장은 [ACTION]을 하지 못한다.", 0, 5, 2, 2, 4);
				Kotori_Toyumi = new newSpecial("밀레니엄", "토요미 코토리", "다음 턴 종료시까지 자신의 1, 2, 3 포지션과 [STRIKER]으 ㅣ포지션을 1 증가시킨다. 그 후 자신의 [STRIKER] 3명의 [HP]를 1 회복시킨다.", 3, 4);
			}
		}

		public class Trinity
		{
			// 트리니티
			public static newStriker Hihumi_Azitani;
			public static newStriker Azusa_Shirazu;
			public static newStriker Koharu_Shimoe;
			public static newStriker Mika_Misono;
			public static newSpecial Nagisa_Kirihuzi;
			public static newSpecial Hanako_Urawa;
			// 정의실현부
			public static newStriker Tsurigi_Kenzaki;
			public static newStriker Hasumi_Hanekawa;
			public static newStriker Ichika_Nazamasa;
			public static newSpecial Mashiro_Shizuyama;

			public static void Init()
			{
				Hihumi_Azitani = new newStriker("트리니티", "아지타니 히후미", "다음 턴 종료 시까지 상대 [STRIKER]를 2장 까지 지정하고 데미지 수치를 1 감소시킨다. 그 후 트래쉬의 [페로로 인형] 1장을 패로 가져올 수 있다.", 3, 5, 2, 2, 5);
				Azusa_Shirazu = new newStriker("트리니티", "시라즈 아즈사", "상대의 [STRIKER] 1장에게 4의 데미지를 준다. 그 후 그 [STRIKER]의 데미지 수치 혹은 사거리 수치가 원래와 다르다면 추가로 1 데미지를 준다.", 0, 5, 2, 2, 5);
				Koharu_Shimoe = new newStriker("트리니티", "시모에 코하루", "상대 1, 2 포지션의 [STRIKER]에게 1의 데미지를 준다. 그 후 자신의 [STRIKER] 전원의 [HP]를 1 회복한다.", 2, 6, 2, 1, 3);
				Mika_Misono = new newStriker("트리니티", "미소노 미카", "상대 [STRIKER] 1장에게 2의 데미지를 준다. 그 후 [STRIKER]에게 자신이 받은 데미지 만큼의 데미지를 준다.", 0, 5, 1, 3, 6);
				Nagisa_Kirihuzi = new newSpecial("트리니티", "키리후지 나기사", "상대 1, 2, 3 포지션의 [STRIKER]에게 1 데미지를 준다. 그 후 [HP]가 가장 낮은 [STRIKER]의 [HP]를 1 회복한다.", 0, 3);
				Hanako_Urawa = new newSpecial("트리니티", "우라와 하나코", "자신의 1, 2 포지션의 [STRIKER]의 [HP]를 3 회복한다. 그 후 [HP]가 가장 낮은 [STRIKER]의 [HP]를 2 회복한다.", 2, 5);
				Tsurigi_Kenzaki = new newStriker("트리니티", "켄자키 츠루기", "자신의 [TRASH]에서 [발포!] 카드를 1장 패로 가져온다. 그 후 코인을 1회 던져서 앞면이 나오면 [SPECIAL] 카드를 1장 패로 가져온다.", 0, 5, 1, 3, 3);
				Hasumi_Hanekawa = new newStriker("트리니티", "하네카와 하스미", "상대 [STRIKER] 1장에게 4의 데미지를 준다. 추가로 패에서 카드 1장을 트래쉬하고 코인을 1회 던져서 앞면이 나오면 2 데미지를 추가로 준다.", 0, 5, 2, 2, 5);
				Ichika_Nazamasa = new newStriker("트리니티", "나카마사 이치카", "상대의 1, 2, 3 포지션의 [STRIKER]에게 2회 데미지를 준다. 그 후 [GOODS] 카드를 1장 이하로 장비하고 있는 상대 [STRIKER] 모두에게 2회 데미지를 준다.", 0, 5, 2, 2, 6);
				Mashiro_Shizuyama = new newSpecial("트리니티", "시즈야마 마시로", "상대 [STRIKER] 1장에게 2의 데미지를 준다. 추가로 코인을 1회 던져 앞면이 나오면 2의 데미지를 추가로 준다.", 0, 3);
			}
		}

		public class Schale
		{
			// 샬레
			public static newSpecial Arona; // 파란봉투
			public static newSpecial Sora; // 마빡왕

			public static void Init()
			{
				Arona = new newSpecial("샬레", "아로나", "자신의 덱 위에서 카드를 4장 넘기고 서로 확인한다. 그 중 [SPECIAL] 카드 1장을 패로 가져온다. 남은 카드는 좋아하는 순서대로 덱 아래로 되돌린다.", 3, 1);
				Sora = new newSpecial("샬레", "소라", "자신의 덱 위에서 카드를 3장 넘기고 서로 확인한다. 그 중 [GOODS] 카드 1장을 패로 가져온다. 남은 카드는 좋아하는 순서대로 덱 아래로 되돌린다.", 3, 1);
			}
		}

		public class ETC
		{
			// 시바세키 라멘
			public static newSpecial Shiba_Master; // 마스터 시바 ㄹ

			// 무소속
			public static newSpecial Work_Foreman; // 용역 반장
			public static newSpecial Thugs; // 불량배

			public static void Init()
			{
				Shiba_Master = new newSpecial("시바세키", "마스터 시바", "덱에서 2장 드로우한다.", 3, 2);
				Work_Foreman = new newSpecial("무소속", "용역 반장", "상대 [STRIKER] 1장에게 달려있는 [GOODS] 카드 1장을 트래쉬한다.", 3, 2);
				Thugs = new newSpecial("무소속", "불량배", "쌍대 패를 보지 않은 채 1장 고르고 덱 아래로 되돌린다.", 3, 2);
			}
		}

		public class Goods
		{
			// 스페셜
			public static newGoods Obstacle; // 엄폐물
			public static newGoods Cap; // 무지 캡모자
			public static newGoods Abydos_BD; // 기초 전술 교육 BD-아비도스
			public static newGoods Gehenna_BD; // 기초 전술 교육 BD-게헨나
			public static newGoods Badge; // 서벌 금속 뱃지
			public static newGoods Amulet; // 교통 안전 부적
			public static newGoods Glove; // 스포츠용 장갑
			public static newGoods Sneekers; // 핑크 스니커즈
			public static newGoods Millennium_BD; // 기초 전술 교육 BD-밀레니엄
			public static newGoods Ikazuchi; // 천둥이
			public static newGoods Trinity_BD; // 기초 전술 교육 BD-트리니티
			public static newGoods Peroro; // 페로로 인형
			public static newGoods Keystone; // 기동석
			public static newGoods Sportbag; // 방수 스포츠백
			public static newGoods Medical_Kit; // 응급키트

			// 발포
			public static Shoot Shoot; // 발포!

			public static void Init()
			{
				Obstacle = new newGoods("엄폐물", "장비한[STRIKER]가 [발포!]로 인한 데미지를 받을 경우 1 경감해준다. 이 카드는 3 이상의 데미지를 입으면 페기한다.", 1, 0);
				Cap = new newGoods("무지 캡모자", "자신의 [STRIKER]의 데미지 수치를 1 증가시킨다.", 1, 0);
				Abydos_BD = new newGoods("기초 전술 교육 BD-아비도스", "이번 턴 자신의 [아비도스] [STRIKER] 또는 [SPECIAL] 카드 1장의 [EX스킬]을 사용하기 위한 코스트는 1 경감한다.", 0, 0);
				Gehenna_BD = new newGoods("기초 전줄 교육 BD-게헨나", "이번 턴 자신의 [게헨나] [STRIKER] 또는 [SPECIAL] 카드 1장의 [EX스킬]을 사용하기 위한 코스트는 1 경감한다.", 0, 0);
				Badge = new newGoods("서벌 금속 뱃지", "장비한 [STRIKER]의 [HP]수치를 1 증가시킨다.", 1, 0);
				Amulet = new newGoods("교통 안전 부적", "장비한 [STRIKER]가 데미지를 받았을 때 덱에서 1장 드로우한다.", 1, 0);
				Glove = new newGoods("스포츠용 장갑", "장비한 [STRIKER]의 [사거리] 수치를 1 증가시킨다.", 1, 0);
				Sneekers = new newGoods("핑크 스니커즈", "장비한 [STRIKER]의 포지션을 1 증가시킨다.", 1, 0);
				Millennium_BD = new newGoods("기초 전술 교육 BD-밀레니엄", "이번 턴 자신의 [밀레니엄] [STRIKER] 또는 [SPECIAL] 카드 1장의 [EX스킬]을 사용하기 위한 코스트는 1 경감한다.", 0, 0);
				Ikazuchi = new newGoods("천둥이", "장비한 [STRIKER]의 [DAMAGE] 수치와 [HP] 수치를 1 올린다. 이 카드는 2 이상의 데미지를 입으면 폐기한다", 1, 0);
				Trinity_BD = new newGoods("기초 전줄 교육 BD-트리니티", "이번 턴 자신의 [트리니티] [STRIKER] 또는 [SPECIAL] 카드 1장의 [EX스킬]을 사용하기 위한 코스트는 1 경감한다.", 0, 0);
				Peroro = new newGoods("페로로 인형", "이 카드는 1, 2 포지션의 카드에만 장비 할 수 있다. 상대는 [발포!]를 사용할 경우 이 카드를 장비한 [STRIKER]만 공격 할 수 있다. 이 카드를 장착한 [STRIKER]가 데미지를 입으면 이 카드를 폐기한다.", 1, 0);
				Keystone = new newGoods("기동석 조각", "자신의 패 1장을 트래쉬하고 자신의 [TRASH]에서 [기동석 조각] 이외의 [GOODS] 카드 1장을 패로 가져온다.", 0, 0);
				Sportbag = new newGoods("방수 스포츠백", "장비한 [STRIKER]가 [발포!]로 데미지를 받았을 경우 [발포!]를 사용한 상대 [STRIKER]에게 1 데미지를 준다.", 1, 0);
				Medical_Kit = new newGoods("응급키트", "자신 필드의 [STRIKER] 1장의 [HP]를 1 회복한다.", 0, 0);

				Shoot = new Shoot();
			}
		}

		public class Za_Warudo
		{
			// 더 월드
			public static newSpecial ZA_WARUDO; // 자 와루도!!! 토키오 토마레!!!
		}
	public static void Init()
		{
			Cards.Abydos.Init();
			Cards.Gehenna.Init();
			Cards.Millennium.Init();
			Cards.Trinity.Init();
			Cards.Schale.Init();
			Cards.ETC.Init();
			Cards.Goods.Init();
		}
	}
}