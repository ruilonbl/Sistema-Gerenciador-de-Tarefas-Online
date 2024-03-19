using System.ComponentModel;

namespace Todo.Entitys.Enums
{
    public enum StatusEnum
    {
        [Description("A fazer")]
        Todo = 0,

        [Description("Fazendo")]
        Doing = 1,

        [Description("Concluido")]
        Done = 2,
    }
}
