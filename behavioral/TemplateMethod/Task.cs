namespace TemplateMethod
{
    public abstract class Task
    {
        private readonly AuditTrail auditTrail;

        protected Task()
        {
            auditTrail = new AuditTrail();
        }
        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
