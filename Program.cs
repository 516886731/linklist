using System;
using System.Collections;
using System.Collections.Generic;

namespace 链
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试
            SimpleLinkList<string> link = new SimpleLinkList<string>();
            link.AppendForFoot("A");
            link.AppendForFoot("B");
            link.AppendForFoot("C");
            link.AppendForFoot("D");
            link.AppendForFoot("E");
            link.InsertNode(1, "Head");
            Console.WriteLine("单链表内容：");
            link.Display();
            link.Delete(5);
            Console.WriteLine("已完成删除单链表中第5行记录数");
            link.Display();
            Console.WriteLine("查询单链表中第1:{0}.第3：{1}", link.GetValueFromNode(1), link.GetValueFromNode(3));
            Console.WriteLine("面试题-->单链表反转");
            link.Reverse();
            Console.WriteLine("----------------------现在开始测试双链表的反转链表--------------------");
            Console.WriteLine("定义双链表中的元素并打印");
            DoubleNode<int> Head = new DoubleNode<int>(0);
            DoubleNode<int> First = new DoubleNode<int>(1);
            DoubleNode<int> Second = new DoubleNode<int>(2);
            DoubleNode<int> Third = new DoubleNode<int>(3);
            DoubleNode<int> Forth = new DoubleNode<int>(4);

            Head.LastNode = null;
            Head.NextNode = First;
            First.LastNode = Head;
            First.NextNode = Second;
            Second.LastNode = First;
            Second.NextNode = Third;
            Third.LastNode = Second;
            Third.NextNode = Forth;
            Forth.LastNode = Third;
            Forth.NextNode = null;

            DoubleLinkList<int> doubleLinkList = new DoubleLinkList<int>();
            doubleLinkList.Display(Head);
            var t = doubleLinkList.Reverse(Head);
            Console.WriteLine("面试题-->双链表反转");
            doubleLinkList.Display(t);
            Console.WriteLine("----------------------现在开始测试单链表的打印公共部分--------------------");
            SimpleLinkList<int> simpleLinkList1 = new SimpleLinkList<int>();
            SimpleLinkList<int> simpleLinkList2 = new SimpleLinkList<int>();

            simpleLinkList1.AppendForFoot(1);
            simpleLinkList1.AppendForFoot(3);
            simpleLinkList1.AppendForFoot(5);
            simpleLinkList1.AppendForFoot(6);
            simpleLinkList1.AppendForFoot(8);
            simpleLinkList1.AppendForFoot(10);
            simpleLinkList1.AppendForFoot(10);

            simpleLinkList2.AppendForFoot(0);
            simpleLinkList2.AppendForFoot(1);
            simpleLinkList2.AppendForFoot(4);
            simpleLinkList2.AppendForFoot(3);
            simpleLinkList2.AppendForFoot(10);
            simpleLinkList2.AppendForFoot(11);

            SimpleLinkCount<int> simpleLinkCount = new SimpleLinkCount<int>();
            simpleLinkCount.FindCommonElement(simpleLinkList1.Head, simpleLinkList2.Head);
            Console.WriteLine("----------------------现在开始测试单链表的判断是否是回文结构笔试题--------------------");
            SimpleLinkList<int> simpleLinkList3 = new SimpleLinkList<int>();
            SimpleLinkList<int> simpleLinkList4 = new SimpleLinkList<int>();

            simpleLinkList3.AppendForFoot(3);
            simpleLinkList3.AppendForFoot(2);
            simpleLinkList3.AppendForFoot(1);
            simpleLinkList3.AppendForFoot(2);
            simpleLinkList3.AppendForFoot(3);

            simpleLinkList4.AppendForFoot(3);
            simpleLinkList4.AppendForFoot(4);
            simpleLinkList4.AppendForFoot(4);
            simpleLinkList4.AppendForFoot(3);

            Console.WriteLine(simpleLinkCount.WrittenForPalindromicStructure(simpleLinkList2.Head));
            Console.WriteLine(simpleLinkCount.WrittenForPalindromicStructure(simpleLinkList3.Head));
            Console.WriteLine(simpleLinkCount.WrittenForPalindromicStructure(simpleLinkList4.Head));

            Console.WriteLine("----------------------现在开始测试单链表的判断是否是回文结构面试题--------------------");
            Console.WriteLine(simpleLinkCount.InterviewForPalindromicStructure(simpleLinkList2.Head));
            Console.WriteLine(simpleLinkCount.InterviewForPalindromicStructure(simpleLinkList3.Head));
            Console.WriteLine(simpleLinkCount.InterviewForPalindromicStructure(simpleLinkList4.Head));

            //Console.WriteLine(simpleLinkCount.Test(simpleLinkList2.Head));
            //Console.WriteLine(simpleLinkCount.Test(simpleLinkList3.Head));
            //Console.WriteLine(simpleLinkCount.Test(simpleLinkList4.Head));

            Console.WriteLine("----------------------现在开始测试单链表的按某数分割的小于等于大于算法题----------------");
            var m = simpleLinkCount.SmallerEqualBigger(simpleLinkList2.Head, 4);
            simpleLinkList2.Display1(m);

            Console.WriteLine("-----------------------现在开始创建并测试特殊单链表的复制算法题-------------------------");
            Console.WriteLine("-----------------------1. 通过字典复制------------------------------------------------");
            SpecialSimpleNode<int> special1 = new SpecialSimpleNode<int>(2);
            SpecialSimpleNode<int> special2 = new SpecialSimpleNode<int>(5);
            SpecialSimpleNode<int> special3 = new SpecialSimpleNode<int>(1);
            SpecialSimpleNode<int> special4 = new SpecialSimpleNode<int>(9);
            SpecialSimpleNode<int> special5 = new SpecialSimpleNode<int>(6);
            SpecialSimpleNode<int> special6 = new SpecialSimpleNode<int>(4);

            special1.Next = special2;
            special2.Next = special3;
            special3.Next = special4;
            special4.Next = special5;
            special5.Next = special6;

            special1.Rand = special5;
            special5.Rand = special6;
            special6.Rand = special4;
            special4.Rand = special2;
            special2.Rand = special3;
            special3.Rand = null;

            var n = simpleLinkCount.CopyForSpecialLinkListByDictionary(special1);
            simpleLinkCount.Display(n);
            Console.WriteLine("-----------------------2. 不通过其他数据结构复制，在链表本身复制---------------------------------");
            var x = simpleLinkCount.CopyForSpecialLinkListByHimself(special1);
            simpleLinkCount.Display(x);
            Console.WriteLine("------------------------测试环链的面试题--------------------------");
            //创建环链1
            SimpleNode<int> node1 = new SimpleNode<int>(1);
            SimpleNode<int> node2 = new SimpleNode<int>(3);
            SimpleNode<int> node3 = new SimpleNode<int>(5);
            SimpleNode<int> node4 = new SimpleNode<int>(7);
            SimpleNode<int> node5 = new SimpleNode<int>(10);
            SimpleNode<int> node6 = new SimpleNode<int>(12);
            SimpleNode<int> node7 = new SimpleNode<int>(13);

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node5;

            //创建两相交直链
            SimpleNode<int> nod1 = new SimpleNode<int>(1);
            SimpleNode<int> nod2 = new SimpleNode<int>(3);
            SimpleNode<int> nod3 = new SimpleNode<int>(5);
            SimpleNode<int> nod4 = new SimpleNode<int>(7);
            SimpleNode<int> nod5 = new SimpleNode<int>(10);
            SimpleNode<int> nod6 = new SimpleNode<int>(12);
            SimpleNode<int> nod7 = new SimpleNode<int>(13);

            nod1.Next = nod2;
            nod2.Next = nod3;
            nod3.Next = nod4;
            nod4.Next = nod5;
            nod5.Next = nod6;
            nod6.Next = nod7;

            SimpleNode<int> no1 = new SimpleNode<int>(6);
            SimpleNode<int> no2 = new SimpleNode<int>(4);
            SimpleNode<int> no3 = new SimpleNode<int>(7);
            SimpleNode<int> no4 = new SimpleNode<int>(3);

            no1.Next = no2;
            no2.Next = no3;
            no3.Next = no4;
            no4.Next = nod5;

            //创建两相交环链,head1=node1;head2=nodex1,为loop相等的
            SimpleNode<int> nodex1 = new SimpleNode<int>(9);
            SimpleNode<int> nodex2 = new SimpleNode<int>(8);
            SimpleNode<int> nodex3 = new SimpleNode<int>(7);

            nodex1.Next = nodex2;
            nodex2.Next = nodex3;
            nodex3.Next = node3;

            //创建两相交环链,head1=node1;head2=nodem1,为两单独的
            SimpleNode<int> nodem1 = new SimpleNode<int>(1);
            SimpleNode<int> nodem2 = new SimpleNode<int>(3);
            SimpleNode<int> nodem3 = new SimpleNode<int>(5);
            SimpleNode<int> nodem4 = new SimpleNode<int>(7);
            SimpleNode<int> nodem5 = new SimpleNode<int>(10);
            SimpleNode<int> nodem6 = new SimpleNode<int>(12);
            SimpleNode<int> nodem7 = new SimpleNode<int>(13);

            nodem1.Next = nodem2;
            nodem2.Next = nodem3;
            nodem3.Next = nodem4;
            nodem4.Next = nodem5;
            nodem5.Next = nodem6;
            nodem6.Next = nodem7;
            nodem7.Next = nodem5;

            //创建两相交环链,为loop不同，但是环相同
            SimpleNode<int> noder1 = new SimpleNode<int>(9);
            SimpleNode<int> noder2 = new SimpleNode<int>(8);
            SimpleNode<int> noder3 = new SimpleNode<int>(7);

            noder1.Next = noder2;
            noder2.Next = noder3;
            noder3.Next = node6;
            SimpleLinkListCountIntersect<int> simpleLinkListCountIntersect = new SimpleLinkListCountIntersect<int>();
            //var u=simpleLinkListCountIntersect.GetLoopNode(node1);
            //Console.WriteLine(u.Value);
            //var e=simpleLinkListCountIntersect.donotHaveLoop(nod1, no1);
            //Console.WriteLine(e.Value);
            var w1=simpleLinkListCountIntersect.GetResult(nod1, no1);
            Console.WriteLine(w1.Value);
            var w2 = simpleLinkListCountIntersect.GetResult(node1, nodex1);
            Console.WriteLine(w2.Value);
            var w3 = simpleLinkListCountIntersect.GetResult(node1, nodem1);
            Console.WriteLine(w3.Value);
            var w4 = simpleLinkListCountIntersect.GetResult(node1, noder1);
            Console.WriteLine(w4.Value);
            Console.ReadLine();
        }
    }


    //定义单链表节点泛型类
    class SimpleNode<T>
    {
        public SimpleNode(T value)
        {
            Value = value;
            Next = null;
        }
        public SimpleNode()
        {
            Value = default(T);
            Next = null;
        }

        public T Value { get; set; }//当前节点的数据
        public SimpleNode<T> Next { get; set; }//下一个节点的地址或者说是指针
    }

    //定义双链表，目的是为了简单测试，所以就不按单链表来定义了
    class DoubleNode<T>
    {
        public DoubleNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public DoubleNode<T> LastNode { get; set; }
        public DoubleNode<T> NextNode { get; set; }

    }

    //定义特殊的单链表，里面比一般单链表多了个随意指向的指针，为下面一个特殊的面试题专用
    class SpecialSimpleNode<T>
    {
        public SpecialSimpleNode(int value)
        {
            Value = value;
        }
        public SpecialSimpleNode<T> Rand { get; set; } = null;
        public SpecialSimpleNode<T> Next { get; set; } = null;
        public int Value { get; set; }
    }

    /// <summary>
    /// 单链表的相关功能实现
    /// </summary>
    /// <typeparam name="T">数值类型是泛型</typeparam> 

    class SimpleLinkList<T>
    {
        public SimpleNode<T> Head { get; set; }//表头
        public SimpleLinkList()
        {
            Head = null;
        }

        /// <summary>
        /// 往单链表尾增加数据
        /// </summary>
        /// <param name="date"></param>
        public void AppendForFoot(T date)
        {
            //初始化需要增加的节点
            SimpleNode<T> foot = new SimpleNode<T>(date);

            //如果没有表头
            if (Head == null)
            {
                Head = foot;
                return;
            }

            var A = Head;
            //如果有表头
            //找到没有下一个next的数据
            while (A.Next != null)
            {
                A = A.Next;
            }
            //赋值
            A.Next = foot;
        }

        /// <summary>
        /// 得出链表的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            if (Head == null)
            {
                return 0;
            }
            var length = 1;
            var A = Head;
            while (A.Next != null)
            {
                length++;
                A = A.Next;
            }
            return length;
        }

        /// <summary>
        /// 删除某个位置节点
        /// </summary>
        /// <param name="i"></param>
        public void Delete(int i)
        {
            //A是被删除节点
            SimpleNode<T> A = new SimpleNode<T>();
            if (i == 1)
            {
                Head = Head.Next;
                return;
            }
            A = Head;
            int j = 1;

            //B节点是被删除的节点的前一个节点
            SimpleNode<T> B = new SimpleNode<T>();

            //判断，如果下一个节点为空，说明后面没有了，比方说就算你想删100个节点，但是链表里只有10个节点，那么删去的是最后一个尾节点
            //如果不是最后一个尾节点，那么就需要比对个数了，j<i说明在此时还没到需要删除的节点，j=i表示，此时这个就是需要删除的节点
            while (A.Next != null && j < i)
            {
                B = A;//把此时的值给上一个节点
                A = A.Next;//A跳到下一个节点
                j++;
            }
            if (j == i)
            {
                B.Next = A.Next;
            }
            if (A.Next == null)
            {
                B.Next = null;
            }
        }

        /// <summary>
        /// 清空链表
        /// </summary>
        public void Clear()
        {
            Head = null;
        }

        /// <summary>
        /// 获得指定节点的值
        /// </summary>
        /// <param name="i">节点位置</param>
        /// <returns></returns>
        public T GetValueFromNode(int i)
        {
            if (i > GetLength() || i < 1 || Head == null)
            {
                Console.WriteLine("该节点不存在");
                return default(T);
            }
            SimpleNode<T> node = new SimpleNode<T>();
            node = Head;
            int j = 1;
            while (node.Next != null && j < i)
            {
                node = node.Next;
                j++;
            }

            return node.Value;
        }

        /// <summary>
        /// 在任意节点插入需要插入的节点
        /// </summary>
        /// <param name="i">需要插入的位置</param>
        /// <param name="item">需要插入的节点的值</param>
        public void InsertNode(int i, T item)
        {
            if (Head == null || i < 1)
            {
                Console.WriteLine("单链表为空或者节点输入有问题");
                return;
            }

            //node是原节点，即需要插入的节点
            SimpleNode<T> node = new SimpleNode<T>();
            //lastnode是上一个节点
            SimpleNode<T> lastnode = new SimpleNode<T>();
            //插入的节点
            SimpleNode<T> simpleNode = new SimpleNode<T>();
            simpleNode.Value = item;

            //插入到头部
            if (i == 1)
            {
                simpleNode.Next = Head;
                Head = simpleNode;
                return;
            }
            node = Head;
            int j = 1;
            while (node.Next != null && j < i)
            {
                lastnode = node;
                node = node.Next;
                j++;
            }
            //指向地址开始改变，因为中间插了个节点
            if (i == j)
            {
                lastnode.Next = simpleNode;
                simpleNode.Next = node;
                return;
            }
            if (node.Next == null)
            {
                node.Next = simpleNode;
                return;
            }
        }

        /// <summary>
        /// 展示链表里面的内容
        /// </summary>
        public void Display()
        {
            SimpleNode<T> node = new SimpleNode<T>();
            node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        public void Display1(SimpleNode<T> head)
        {
            SimpleNode<T> node = new SimpleNode<T>();
            node = head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        /// <summary>
        /// 单链表反转
        /// </summary>
        public void Reverse()
        {
            if (GetLength() == 1 || Head == null)
            {
                return;
            }

            //反转后的新节点
            SimpleNode<T> NewNode = null;
            //当前正在反转的节点
            SimpleNode<T> CurrentNode = Head;
            //暂存当前节点的下一个节点
            SimpleNode<T> TempNode = new SimpleNode<T>();

            //当前节点不为空的话，可以反转，直到当前节点为空，说明链表已经反转完成
            while (CurrentNode != null)
            {
                //用TempNode暂存当前节点的下一个节点
                TempNode = CurrentNode.Next;
                //把当前节点的下一个节点（next）重新赋值，下一次循环时，NewNode就是上一个新的节点，直到下面的一步，NewNode又变成当前新节点了
                CurrentNode.Next = NewNode;
                //把当前节点的所有（value，next）赋值给新节点
                NewNode = CurrentNode;
                //给下一个节点的值重新复制给当前节点，方便下一次使用
                CurrentNode = TempNode;
            }
            //最后一个新节点即为新的head
            Head = NewNode;

            Display();
        }
    }

    /// <summary>
    /// 单链表算法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SimpleLinkCount<T>
    {
        // 给定两个有序单链表的头指针head1和head2，打印两个链表的公共部分
        //注意是有序单链表，链表里的元素已经排好序了，假设按从小到大来排序
        public void FindCommonElement(SimpleNode<int> head1, SimpleNode<int> head2)
        {
            //1 3 5 6 8 10 10
            //0 1 4 6 10 11
            while (head1 != null && head2 != null)
            {
                if (head1.Value == head2.Value)
                {
                    Console.WriteLine(head1.Value);
                    head1 = head1.Next;
                    head2 = head2.Next;
                }
                else
                {
                    if (head1.Value < head2.Value)
                    {
                        head1 = head1.Next;
                    }
                    else
                    {
                        head2 = head2.Next;
                    }
                }
            }
        }

        //给定一个单链表的头节点head，请判断该链表是否为回文结构
        //1->2->1，返回true； 1->2->2->1，返回true；15->6->15，返回true； 1->2->3，返回false
        //笔试写法：利用栈
        public bool WrittenForPalindromicStructure(SimpleNode<int> head)
        {
            var tempNode = head;
            Stack stack = new Stack();
            while (tempNode != null)
            {
                stack.Push(tempNode.Value);
                tempNode = tempNode.Next;
            }
            while (stack.Count != 0)
            {
                if ((int)stack.Pop() != head.Value)
                {
                    return false;
                }
                head = head.Next;
            }
            return true;
        }

        //给定一个单链表的头节点head，请判断该链表是否为回文结构
        //1->2->1，返回true； 1->2->2->1，返回true；15->6->15，返回true； 1->2->3，返回false
        //面试写法：利用快慢指针
        public bool InterviewForPalindromicStructure(SimpleNode<int> head)
        {
            if (head == null || head.Next == null)
            {
                return true;
            }
            SimpleNode<int> n1 = head;
            SimpleNode<int> n2 = head;
            while (n2.Next != null && n2.Next.Next != null)
            { // find mid node
                n1 = n1.Next; // n1 -> mid
                n2 = n2.Next.Next; // n2 -> end
            }
            n2 = n1.Next; // n2 -> right part first node
            n1.Next = null; // mid.next -> null
            SimpleNode<int> n3 = null;
            while (n2 != null)
            { // right part convert
                n3 = n2.Next; // n3 -> save next node
                n2.Next = n1; // next of right node convert
                n1 = n2; // n1 move
                n2 = n3; // n2 move
            }
            n3 = n1; // n3 -> save last node
            n2 = head;// n2 -> left first node
            bool res = true;
            while (n1 != null && n2 != null)
            { // check palindrome
                if (n1.Value != n2.Value)
                {
                    res = false;
                    break;
                }
                n1 = n1.Next; // right to mid
                n2 = n2.Next; // left to mid
            }
            n1 = n3.Next;
            n3.Next = null;
            while (n1 != null)
            { // recover list
                n2 = n1.Next;
                n1.Next = n3;
                n3 = n1;
                n1 = n2;
            }
            return res;
        }

        public bool Test(SimpleNode<int> head)
        {
            if (head == null || head.Next == null)
            {
                return true;
            }
            SimpleNode<int> oneStep = head;
            SimpleNode<int> twoStep = head;

            while (twoStep.Next != null && twoStep.Next.Next != null)
            {
                oneStep = oneStep.Next;
                twoStep = twoStep.Next.Next;
            }
            var originForRight = oneStep.Next;//链表右侧部分第一个数
            //开始反转右侧的数
            //第一步，先斩断前缘，左侧和右侧分界处且靠近左侧的（对偶数而言），对奇数而言就是中间数
            oneStep.Next = null;
            SimpleNode<int> n1 = null;
            //开始反转
            while (originForRight != null)
            {
                n1 = originForRight.Next;
                originForRight.Next = oneStep;
                oneStep = originForRight;
                originForRight = n1;
            }
            //开始比较是否结构完全一样
            SimpleNode<int> n2 = head;
            twoStep = oneStep;//存右侧的第一个值，也就是原链表右侧的最后一个值
            bool res = true;
            while (oneStep != null && n2 != null)
            {
                if (oneStep.Value != n2.Value)
                {
                    res = false;
                    break;
                }
                oneStep = oneStep.Next;
                n2 = n2.Next;
            }
            n2 = twoStep.Next;
            twoStep.Next = null;

            //判断结束，开始反转回去
            while (n2 != null)
            {
                oneStep = n2.Next;
                n2.Next = twoStep;
                twoStep = n2;
                n2 = oneStep;
            }
            return res;
        }

        //将单向链表按某值划分成左边小、中间相等、右边大的形式
        //【题目】给定一个单链表的头节点head，节点的值类型是整型，再给定一个整 数pivot。实现一个调整链表的函数，将链表调整为左部分都是值小于pivot的 节点，中间部分都是值等于pivot的节点，右部分都是值大于pivot的节点。 
        public SimpleNode<int> SmallerEqualBigger(SimpleNode<int> head, int pivot)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            //分别是小于的首，小于的尾，等于首，等于尾，大于首，大于尾
            SimpleNode<int> sh = null;
            SimpleNode<int> st = null;
            SimpleNode<int> eh = null;
            SimpleNode<int> et = null;
            SimpleNode<int> bh = null;
            SimpleNode<int> bt = null;

            SimpleNode<int> temp = null;
            while (head != null)
            {
                temp = head.Next;
                head.Next = null;
                if (head.Value < pivot)
                {
                    if (sh == null)
                    {
                        sh = head;
                        st = head;
                    }
                    st.Next = head;
                    st = head;
                }
                else if (head.Value == pivot)
                {
                    if (eh == null)
                    {
                        eh = head;
                        et = head;
                    }
                    et.Next = head;
                    et = head;
                }
                else if (head.Value > pivot)
                {
                    if (bh == null)
                    {
                        bh = head;
                        bt = head;
                    }
                    bt.Next = head;
                    bt = head;
                }
                head = temp;
            }

            //if (sh != null)
            //{
            //    st.Next = eh;
            //    et = et == null ? st : et;
            //}
            //if (eh != null)
            //{
            //    et.Next = bh;
            //}

            //测试自己写的判断连接
            if (sh != null)
            {
                if (eh != null)
                {
                    st.Next = eh;
                    et.Next = bh;
                }
                else
                {
                    if (bh != null)
                    {
                        st.Next = bh;
                        bt.Next = null;
                    }
                    else
                    {
                        st.Next = null;
                    }
                }
            }
            else
            {
                if (eh != null)
                {
                    et.Next = bh;
                    bt.Next = null;
                }
                else
                {
                    bt.Next = null;
                }
            }

            return sh != null ? sh : (eh != null ? eh : bh);
        }


        //复制含有随机指针节点的链表
        //【题目】一种特殊的单链表节点类描述如下 class Node { int value; Node next; Node rand; Node(int val) { value = val; } }
        //rand指针是单链表节点结构中新增的指针，rand可能指向链表中的任意一个节 点，也可能指向null。给定一个由Node节点类型组成的无环单链表的头节点 head，请实现一个函数完成这个链表的复制，并返回复制的新链表的头节点。 

        //第一种方式，通过字典的方式复制
        public SpecialSimpleNode<T> CopyForSpecialLinkListByDictionary(SpecialSimpleNode<T> head)
        {
            SpecialSimpleNode<T> special = head;
            Dictionary<SpecialSimpleNode<T>, SpecialSimpleNode<T>> dictionary = new Dictionary<SpecialSimpleNode<T>, SpecialSimpleNode<T>>();
            //往字典里面复制值
            while (special != null)
            {
                dictionary.Add(special, new SpecialSimpleNode<T>(special.Value));
                special = special.Next;
            }
            special = head;
            while (special != null && special.Next != null)
            {
                dictionary[special].Next = dictionary[special.Next];
                if (special.Rand != null)
                {
                    dictionary[special].Rand = dictionary[special.Rand];
                }
                special = special.Next;
            }
            return dictionary[head];
        }

        //第二种方式，通过链表本身复制,将复制后的元素放在原始元素的后一位上即可，其实这个步骤就是另一种方式的查找，而不是字典方式的查找
        public SpecialSimpleNode<T> CopyForSpecialLinkListByHimself(SpecialSimpleNode<T> head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            SpecialSimpleNode<T> special = head;
            SpecialSimpleNode<T> temp = head.Next;//暂存下一个节点

            //将链表里的元素连在一起
            while (special != null && special.Next != null)
            {
                var t = new SpecialSimpleNode<T>(special.Value);
                special.Next = t;
                special = temp;
                t.Next = special;
                temp = temp.Next;
            }
            special.Next = new SpecialSimpleNode<T>(special.Value);
            special = head;
            //Display(head);
            SpecialSimpleNode<T> copyNode = null;//复制后的起点
            //设置复制链表的副本的Rand指针
            while (special != null)
            {
                temp = special.Next.Next;
                copyNode = special.Next;
                copyNode.Rand = special.Rand != null ? special.Rand.Next : null;
                special = temp;
            }
            special = head;
            SpecialSimpleNode<T> t1 = special.Next;//复制后的起点
            copyNode = null;//复制
            //设置复制链表的副本的Rand指针
            while (special != null)
            {
                temp = special.Next.Next;
                copyNode = special.Next;
                special.Next = temp;
                copyNode.Next = temp != null ? temp.Next : null;
                special = temp;
            }
            return t1;
        }
        //以打印的方式展示复制后的链表
        public void Display(SpecialSimpleNode<T> head)
        {
            SpecialSimpleNode<T> node = new SpecialSimpleNode<T>(0);
            node = head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

    }



    /// <summary>
    /// 双链表的相关功能实现
    /// </summary>
    /// <typeparam name="T">数值类型是泛型</typeparam>
    class DoubleLinkList<T>
    {
        //public DoubleNode<T> Head { get; set; }
        //public DoubleLinkList()
        //{
        //    Head = null;
        //}
        //双链表反转
        public DoubleNode<T> Reverse(DoubleNode<T> head)
        {
            DoubleNode<T> CurrentNode = head;
            DoubleNode<T> TempNode = null;
            DoubleNode<T> NewNode = null;

            while (CurrentNode != null)
            {
                TempNode = CurrentNode.NextNode;
                CurrentNode.NextNode = NewNode;
                NewNode = CurrentNode;
                NewNode.LastNode = TempNode;
                CurrentNode = TempNode;
            }
            return NewNode;
        }

        public void Display(DoubleNode<T> head)
        {
            if (head == null)
            {
                Console.WriteLine("双链表为空");
            }
            DoubleNode<T> end = null;
            //正向链表打印
            Console.WriteLine("双链表的正向打印");
            while (head != null)
            {
                Console.WriteLine(head.Value);
                end = head;
                head = head.NextNode;
            }

            //反向链表打印
            Console.WriteLine("双链表的反向打印");
            while (end != null)
            {
                Console.WriteLine(end.Value);
                end = end.LastNode;
            }
        }
    }

    //两个单链表相交的一系列问题
    //【题目】给定两个可能有环也可能无环的单链表，头节点head1和head2。请实 现一个函数，如果两个链表相交，请返回相交的 第一个节点。如果不相交，返 回null
    class SimpleLinkListCountIntersect<T>
    {
        //判断是否有环，有的话则返回环的第一个点，没有则返回空
        public SimpleNode<T> GetLoopNode(SimpleNode<T> head)
        {
            //判断是否可能有环
            if (head==null||head.Next==null||head.Next.Next==null)
            {
                return null;
            }

            SimpleNode<T> loopslow = head.Next;
            SimpleNode<T> loopquick = head.Next.Next;
            while (loopquick != loopslow)
            {
                if (loopquick.Next == null|| loopquick.Next.Next == null)
                {
                    return null;
                }
                loopquick = loopquick.Next.Next;
                loopslow = loopslow.Next;
            }
            loopquick = head;
            while (loopquick!=loopslow)
            {
                loopquick = loopquick.Next;
                loopslow = loopslow.Next;
            }
            return loopquick;
        }
        //两条直单链相交
        public SimpleNode<T> DonotHaveLoop(SimpleNode<T> head1,SimpleNode<T> head2)
        {
            if (head1==null||head2==null||head1.Next==null||head2.Next==null)
            {
                return null;
            }
            SimpleNode<T> longNode = head1;//长链表
            SimpleNode<T> smallNode = head2;//短链表
            int n = 0;//用来记录两个链表长度的差值
            SimpleNode<T> t1=null;
            SimpleNode<T> t2 = null;

            while (longNode!=null)
            {
                n++;
                t1 = longNode;
                longNode = longNode.Next;
            }
            while (smallNode!=null)
            {
                n--;
                t2 = smallNode;
                smallNode = smallNode.Next;
            }
            if (t1!=t2)
            {
                return null;
            }
            longNode = n > 0 ? head1 : head2;
            smallNode = longNode == head1 ? head2 : head1;
            n = Math.Abs(n);
            while (n>0)
            {
                n--;
                longNode = longNode.Next;
            }
            while (longNode!=smallNode)
            {
                longNode = longNode.Next;
                smallNode = smallNode.Next;
            }
            return longNode;
        }
        //两条环链相交
        public SimpleNode<T> BothLoop(SimpleNode<T> loop1,SimpleNode<T> loop2,SimpleNode<T> head1,SimpleNode<T> head2)
        {
            if (head1==null||head2==null)
            {
                return null;
            }
            SimpleNode<T> leftNode = head1;
            SimpleNode<T> rightNode = head2;
            int n = 0;
            if (loop1==loop2)
            {
                while (leftNode!=loop1)
                {
                    n++;
                    leftNode = leftNode.Next;
                }
                while (rightNode!=loop2)
                {
                    n--;
                    rightNode = rightNode.Next;
                }
                leftNode = n > 0 ? head1 : head2;
                rightNode = leftNode == head1 ? head2 : head1;
                n = Math.Abs(n);
                while (n>0)
                {
                    n--;
                    leftNode = leftNode.Next;
                }
                while (leftNode!=rightNode)
                {
                    leftNode = leftNode.Next;
                    rightNode = rightNode.Next;
                }
                return leftNode;
            }
            SimpleNode<T> replace = loop1.Next;
            while (replace!=loop1)
            {
                if (replace==loop2)
                {
                    return loop1;
                }
                replace = replace.Next;
            }
            return null;
        }
        //结合上面三个函数，进行解题的总函数设计
        public SimpleNode<T> GetResult(SimpleNode<T> head1, SimpleNode<T> head2)
        {
            if (head1==null||head2==null||head2.Next==null||head1.Next==null)
            {
                return null;
            }
            SimpleNode<T> loop1= GetLoopNode(head1);
            SimpleNode<T> loop2 = GetLoopNode(head2);
            if (loop1==null&&loop2==null)
            {
                return DonotHaveLoop(head1, head2); 
            }
            if (loop1!=null&&loop2!=null)
            {
                return BothLoop(loop1, loop2, head1, head2);
            }
            return null;
        }
    }
}
