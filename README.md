Kasen
===

C# utility library.

```
https://github.com/suzukun/kasen.git?path=src
```

## NEW

### Collection

#### Compact(List list)
配列から0、空文字、nullを除いた新しい配列を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "", "C" };

__.Compact(list);
// => ["A", "B", "C"]
```
---

#### Count((List | Dictionary) collection, Func callback)
配列・辞書に指定したテストを実行し、合格した要素の数を返します。
##### Example
```cs
List<int> list = new List<int>(){ 0, 2, 4, 6, 8 };

__.Count(list, (value, index, self) =>
{
  return value >= 2;
});
// => 4
```
---

#### Difference(List list1, List list2)
比較対象の配列に含まれていない要素のみを含む新しい配列を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B" };
List<string> list2 = new List<string>(){ "A", "C" };

__.Difference(list1, list2);
// => ["B"]
```
---

#### Intersection(List list1, List list2)
比較対象の配列に含まれている要素のみを含む新しい配列を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B" };
List<string> list2 = new List<string>(){ "A", "C" };

__.Intersection(list1, list2);
// => ["A"]
```
---

#### Shuffle(List list)
シャッフルされた新しい配列を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Shuffle(list);
// => ["D", "A", "C", "B"]
```
---

#### Slice(List list, int startIndex, int endIndex)
配列の指定されたstartIndexから指定されたendIndexまでの要素を含んだ新しい要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Slice(list, 1, 2);
// => ["B", "C"]

__.Slice(list, 2, -1);
// => ["C", "D"]
```
---

#### Union(List list1, List list2)
2つの配列を結合した新しい配列を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B" };
List<string> list2 = new List<string>(){ "A", "C" };

__.Union(list1, list2);
// => ["A", "B", "C"]
```
---

#### Unique(List list)
重複のない新しい配列を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "A", "C" };

__.Unique(list);
// => ["A", "B", "C"]
```
---

#### Unzip(List list)
タプル配列を2つに分割した新しい配列を返します。
##### Example
```cs
List<(string, int)> list = new List<(string, int)>()
{
  ("A", 0),
  ("B", 2),
  ("C", 4),
};

__.Unzip(list);
// => (["A", "B", "C"], [0, 2, 4])
```
---

#### Xor(List list1, List list2)
2つの配列から片方にしか存在しない値のみを含む新しい配列を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B" };
List<string> list2 = new List<string>(){ "A", "C" };

__.Xor(list1, list2);
// => ["B", "C"]
```
---

#### Zip(List list)
2つの配列から値をタプルにした新しい配列を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B", "C" };
List<int> list2 = new List<int>(){ 0, 2, 4 };

__.Zip(list1, list2);
// => [("A", 0), ("B", 2), ("C", 4)]
```
---

### Function

#### Junction((List | Dictionary) collection)
キーによって処理を変える関数を返します。
##### Example
```cs
Func<string, int, int> func = __.Junction(
  ("A", (int v) => v + v),
  ("B", (int v) => v * v));

func("A", 3);
// => 6

func("B", 3);
// => 9
```
---

### Number

#### RangeMapper(float value, int fromMin, int fromMax, int toMin, int toMax)
指定した範囲の入力値を指定した範囲の出力値に変換します。
##### Example
```cs
__.RangeMapper(0.5f, 0f, 1f, 0f, 10f);
// => 5f
```
---

### String

#### CamelCase(string value, bool isUpper = false)
文字列をキャメルケースに変換します。
##### Example
```cs
__.CamelCase("a-bc-d");
// => aBcD

__.CamelCase("a-bc-d", true);
// => ABcD
```
---

#### KebabCase(string value)
文字列をケバブケースに変換します。
##### Example
```cs
__.KebabCase("aBcD");
// => a-bc-d
```
---

#### SnakeCase(string value)
文字列をスネークケースに変換します。
##### Example
```cs
__.SnakeCase("aBcD");
// => a_bc_d
```
---

## Documentation

### Another

#### UniqueId()
ユニークなIDを返します。
##### Example
```cs
__.UniqueId();
// => 0

__.UniqueId();
// => 1
```
---

### Collection

#### Chunk(List list, int size = 1)
配列の中身を指定数ごとに分割した新しい配列を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Chunk(list, 2);
// => [["A", "B"], ["C", "D"]]
```
---

#### Concat(params (List | Dictionary)[] collections)
複数の配列・辞書を結合した新しい配列・辞書を返します。
##### Example
```cs
List<string> list1 = new List<string>(){ "A", "B" };
List<string> list2 = new List<string>(){ "C", "D" };

__.Concat(list1, list2);
// => ["A", "B", "C", "D"]
```
---

#### Each((List | Dictionary) collection, Action callback)
配列・辞書の要素を繰り返し処理します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Each(list, (value, index, self) =>
{
  // ("A", 0, list)
  // ("B", 1, list)
  // ...
});
```
---

#### Every((List | Dictionary) collection, Func callback)
配列・辞書の全ての要素が指定したテストに合格するかをテストします。
##### Example
```cs
List<stint> list = new List<string>(){ "A", "B", "C", "D" };

__.Every(list, (value, index, self) =>
{
  return value != "Z";
});
// => true

__.Every(list, (value, index, self) =>
{
  return value != "A";
});
// => false
```
---

#### Fill((List | Dictionary) collection, T value)
配列・辞書の全ての要素の値が指定した値になった新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Fill(list, "Z");
// => ["Z", "Z", "Z", "Z"]
```
---

#### Filter((List | Dictionary) collection, Func callback)
配列・辞書に指定したテストを実行し、合格した要素のみを含む新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Filter(list, (value, index, self) =>
{
  return value == "A" || value == "C";
});
// => ["A", "C"]
```
---

#### Find((List | Dictionary) collection, Func callback)
配列・辞書に指定したテストを実行し、最初に合格した要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Find(list, (value, index, self) =>
{
  return value == "B";
});
// => "B"
```
---

#### First(List list)
配列の最初の要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.First(list);
// => "A"
```
---

#### Flat(List lists)
サブ配列を結合します。
##### Example
```cs
List<List<string>> lists = new List<List<string>>()
{
  new List<string>(){ "A", "B" },
  new List<string>(){ "C", "D" }
};

__.Flat(lists);
// => ["A", "B", "C", "D"]
```
---

#### Includes((List | Dictionary) collection, T value)
配列・辞書に指定された要素が含まれているかをテストします。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Includes(list, "C");
// => true
```
---

#### Keys((List | Dictionary) collection)
配列・辞書のキー一覧を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Keys(list);
// => [0, 1, 2, 3]
```
---

#### Last(List list)
配列の最後の要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Last(list);
// => "D"
```
---

#### Map((List | Dictionary) collection, Func callback)
配列・辞書の要素を繰り返し処理し、その結果からなる新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Map(list, (value, index, self) =>
{
  return value + value;
});
// => ["AA", "BB", "CC", "DD"]
```
---

#### MapKeys((List | Dictionary) collection, Func callback)
配列・辞書の要素を繰り返し処理し、その結果をキーとした新しい辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.MapKeys(list, (value, index, self) =>
{
  return value + value;
});
// => { "AA": "A", "BB": "B", "CC": "C":, "DD": "D" }
```
---

#### MapValues((List | Dictionary) collection, Func callback)
配列・辞書の要素を繰り返し処理し、その結果を値とした新しい辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.MapValues(list, (value, index, self) =>
{
  return value + value;
});
// => { 0: "AA", 1: "BB", 2: "CC", 3: "DD" }
```
---

#### Nth(List list, int index)
配列から指定されたindexの要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Nth(list, 0);
// => "A"

__.Nth(list, -1);
// => "D"
```
---

#### Omit((List | Dictionary) collection, params T[] keys)
配列・辞書から指定されたキーの要素を除いた新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Omit(list, 0, 2);
// => ["B", "D"]
```
---

#### Pick((List | Dictionary) collection, params T[] keys)
配列・辞書から指定されたキーの要素のみを含んだ新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Pick(list, 0, 2);
// => ["A", "C"]
```
---

#### Reduce((List | Dictionary) collection, Func callback, T initialize)
配列・辞書を繰り返し処理し、最終の結果を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Reduce(list, (result, value) =>
{
  result.Add(value, value + value)

  return result;
}, new Dictionary<string, string>());
// => { "A": "AA", "B": "BB", "C": "CC", "D", "DD" }
```
---

#### Sample((List | Dictionary) collection)
配列・辞書からランダムに一つ要素を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Sample(list);
// => "A" or "B" or "C" or "D"
```
---

#### Set(Dictionary dictionary, TK key, TV value)
辞書に指定したキー・値をセットします。
##### Example
```cs
Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
  { "A": 100 },
  { "B": 200 }
};

__.Set(dictionary, "A", 1000);
// => { "A": 1000, "B": 200 }

__.Set(dictionary, "C", 300);
// => { "A": 1000, "B": 200, "C": 300 }
```
---

#### Some((List | Dictionary) collection, Func callback)
配列・辞書に指定したテストを実行し、一つ以上合格するかをテストします。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Some(list, (value, index, self) =>
{
  return value == "B";
});
// => true
```
---

#### ToString((List | Dictionary) collection, string separator)
配列・辞書を文字列に変換します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.ToString(list, "-");
// => "A-B-C-D"
```
---

#### Values(Dictionary dictionary)
辞書の値一覧を返します。
##### Example
```cs
Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
  { "A": 100 },
  { "B": 200 }
};

__.Values(dictionary);
// => [100, 200]
```
---

#### Within((List | Dictionary) collection, params T[] values)
配列・辞書から指定された値の要素のみを含んだ新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Within(list, "A", "C");
// => ["A", "C"]
```
---

#### Without((List | Dictionary) collection, params T[] values)
配列・辞書から指定された値の要素を除いた新しい配列・辞書を返します。
##### Example
```cs
List<string> list = new List<string>(){ "A", "B", "C", "D" };

__.Without(list, "A", "C");
// => ["B", "D"]
```
---

### Function

#### Memoize(Func callback)
関数をメモ化します。
##### Example
```cs
__.Memoize((int value) =>
{
  return value + value;
});
// => Func<int, int>
```
---

#### Once(Action callback)
一度だけ実行可能な関数を返します。
##### Example
```cs
__.Once(() => { /* ... */ });
// => Action
```
---

#### Pipeline(T value)
疑似的なメソッドチェーンを提供します。
##### Example
```cs
__.Pipeline(1)
  .Chain(x => x * 2)
  .Chain(x => x * 10)
  .Chain(x => x.ToString())
  .Value();
// => "20"
```
---

#### Throttle(Action callback)
指定したミリ秒置きに実行可能な関数を返します。
##### Example
```cs
__.Throttle(() => { /* ... */ }, 1000);
// => Action
```
---

### Number

#### Clamp(float value, float min, float max)
値を指定した最小値・最大値の範囲で切った値を返します。
##### Example
```cs
__.Clamp(100, 0, 50);
// => 50
```
---

#### Constants
汎用的な定数群です。
##### Example
```cs
__.PI;
__.TAU;
```
---

#### InRange(float value, float min, float max)
値が指定した最小値・最大値の範囲に含まれているかをテストします。
##### Example
```cs
__.InRange(25, 0, 50);
// => true
```
---

#### Random(float min, float max)
指定した最小値・最大値の範囲の乱数を返します。
##### Example
```cs
__.Random(0, 50);
// => 0 <= value <= 50
```
---

#### Range(int size)
指定した長さの配列を返します。
##### Example
```cs
__.Range(5);
// => [0, 1, 2, 3, 4]
```
---

#### Saturate(float value)
値を0~1の範囲で切った値を返します。
##### Example
```cs
__.Saturate(1.1f);
// => 1f
```
---

#### Step(float threshold, float value)
閾値未満の場合は0fを閾値以上の場合は1fを返します。
##### Example
```cs
__.Step(0.5f, 0.8f);
// => 1f
```
---
