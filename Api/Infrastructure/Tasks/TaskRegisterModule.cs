
using Ninject.Modules;
namespace Api.Infrastructure.Tasks
{
    public class TaskRegisterModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<ITaskManager>().To<TaskManager>();
        }
    }
}